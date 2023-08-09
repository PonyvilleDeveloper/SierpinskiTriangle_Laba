module backend.database;																		//Модуль по работе с БД
import std.process;																				//Импорт модуля для работы со сторонними программами и управления ими
import std.array : join;																		//Импорт функции объединения массива в одно значение

class DataManager {																				//Класс менеджера данных
    private:
        string[] output, errs;																	//Массивы для хранения выходных данных и сообщений об ошибках
        string filename;																		//Имя файла БД
        bool executeSQL(string odf, string[] sql ...) {											//Функция исполнения любого SQL
            output = [];																		//Обнуление вывода
			errs = [];																			//Обнуление ошибок
            ProcessPipes pipes = pipeProcess(["sqlite3", odf]);									//Подключение к консольному клиенту SQLite3
            pipes.stdin.writeln(".open " ~ filename);											//Подача команды на открытие БД
            foreach(line; sql)
                pipes.stdin.writeln(line);														//Исполнение каждой команды SQL
            pipes.stdin.writeln(".quit");														//Выход из клиента
            pipes.stdin.flush();																//Очистка ввода клиента
            pipes.stdin.close();																//Закрытие потока ввода клиента
            foreach (line; pipes.stdout.byLine)
		        this.output ~= line.idup;														//Получение вывода клиента
			foreach (line; pipes.stderr.byLine)
		        this.errs ~= line.idup;															//Получение сообщений об ошибках клиента
            return wait(pipes.pid) == 0 && errs == [];											//Возвращаем лог. значение: ИСТИНА, если клиент не вылетел и нет ошибок
        }
    public:
        this(string file) {																		//Конструктор класса
            this.filename = file;																//Установка поля с именем файла БД
        }

    bool createTable(string name, string[] fields ...) {										//Функция создания таблицы (пока без настроек ключей)
		string[] __flds = [];																	//Буфер для обработки аргумента fields
		foreach(f; fields[0..$-1])																//Обрабатываем значения fields кроме последнего
			__flds ~= f ~ ", ";																	//Добавляем к ним запятые (Синтаксис SQL)
		__flds ~= fields[$-1];																	//Добавляем в буфер последнее значение
		return executeSQL("-line", "create table ", name, "(", join(__flds), ");");				//Исполняем SQL
    }
    bool putData(string table, string columns, string[] values ...) {							//Функция помещения данных в таблицу
		string[] __vls = [];																	//Также буфер для обаботки values
		foreach(v; values[0..$-1])																//К каждому v из values
			__vls ~= v ~ ", ";																	//Добавляем запятую
		__vls ~= values[$-1] ~ ";";																//Включаем последнее значение в буфер вместе с точкой-запятой (Синтаксис SQL)
		return executeSQL("-line", "insert into ", table, columns, " values ", join(__vls));	//Исполняем SQL
    }
    bool extractData(string table, string fields = "*", string format = "-line") {				//Достаём данные из таблицы
		return executeSQL(format, "select ", fields, " from ", table, ";");						//Исполняем SQL
    }
    @property string[] data() { return this.output; }											//Доступ к данным из БД
	@property string[] errors() { return this.errs; }											//Доступ к сообщениям об ошибках клиента SQLite3
}

unittest {
	//Для запуска теста пропишитие в cmd такую команду: dmd -unittest -main -run database.d
	//Команду нужно исполнять в одной папке с этим файлом
	//В одной папке с этимс файлом должен лежать sqlite3.exe или путь к нему должен быть указан в %path%
    import std.stdio : readln, writeln;
	import std.file : exists;
    scope(failure) writeln("FAIL");
	scope(success) {
		writeln("Test ended. Press 'enter' for exit and delete 'test.db'");
		readln;
		executeShell("del test.db");
	}
    DataManager dm = new DataManager("test.db");	
    assert(dm.createTable("users", "id integer", "name text"));
	assert(dm.putData("users", "(id, name)", "(1, 'Tom')", "(2, 'Elsa')"));
	assert(dm.extractData("users", "*", "-json"));
    writeln("[DATA]:", dm.data);
	writeln("[ERRORS]:", dm.errors);
}