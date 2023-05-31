namespace Laba {
    public partial class Form1 : Form {                                                             //Класс формы (окна) рисовальщика
        private List<Triangle> fractal;                                                             //Список треугольников, из которых состоит фрактал
        private byte Step;                                                                          //Номер шага посторения
        private Bitmap back_buff;                                                                   //Буферное изображение для рисования треугольников
        public Form1() {                                                                            //Конструктор формы (окна)
            InitializeComponent();                                                                  //Отрисовка интерфейса
            fractal = new();                                                                        //Иниц-ия списка треугольников
            Step = 0;                                                                               //Начальный шаг = 0
            StepShow.Text = $"Шаг номер {Step}";                                                    //Вывод шага
            back_buff = new(FractalPlace.Width, FractalPlace.Height);                               //Иниц-ия буфера рисования
        }
        private void ShowTriangles() {                                                              //Функция отрисовки треугольников в буфере
            using (var art = Graphics.FromImage(back_buff)) {                                       //Используя графику на этом буфере
                art.Clear(Color.White);                                                             //Очищаем его белым
                fractal.ForEach(t => t.Draw(in art, Convert.ToByte(changeScale.Value)));            //Рисуем каждый треугольник
            }                                                                                       //Высвобождаем ресурсы
        }
        private void next_Click(object sender, EventArgs e) {                                       //Обработка следующего шага
            Step++;                                                                                 //Инкремент номера
            StepShow.Text = $"Шаг номер {Step}";                                                    //Вывод номера
            List<Triangle> buff = new List<Triangle>();                                             //Буфер треугольников
            foreach (var t in fractal)                                                              //Для каждого существующего треугольника
                buff.AddRange(t.Separate());                                                        //Вызываем метод делящий его на 6 новых и записываем их в буфер
            fractal = buff;                                                                         //Подменяем фрактал буфером
        }
        private void FractalPlace_Paint(object sender, PaintEventArgs e) {                          //Отрисовка фрактала в окне
            ShowTriangles();                                                                        //Отрисовываем сначала в буфере
            e.Graphics.Clear(Color.White);                                                          //Очищаем окошко
            e.Graphics.DrawImage(back_buff, 0, 0);                                                  //Выводим буфер
        }
        private void save_Click(object sender, EventArgs e) {                                       //Сохранение изображения
            SaveFileDialog dialog = new();                                                          //Новый диалог сохранения
            dialog.Title = "Сохранить фрактал...";                                                  //Настройки надписи
            dialog.OverwritePrompt = true;                                                          //Выдача предупреждений о попытке перезаписи сущ-х файлов включена
            dialog.Filter = "Image Files(*.JPG)|*.JPG";                                             //Настройка формата
            if (dialog.ShowDialog() == DialogResult.OK) {                                           //Если согласились на сохранение
                using (var file = File.Create(dialog.FileName)) {                                   //Используя этот файловый поток
                    var s = Convert.ToByte(changeScale.Value);                                      //Узнаём масштаб
                    var img = back_buff.Clone(new(0, 0, 400 * s, 400 * s), back_buff.PixelFormat);  //Вырезаем левый верхний угол с фракталом
                    img.Save(file, System.Drawing.Imaging.ImageFormat.Jpeg);                        //Сохраняем
                    img.Dispose();                                                                  //Освобождаем картинку
                }                                                                                   //Освобождаем файл
            }
        }

        private void Form1_Load(object sender, EventArgs e) {                                       //После загрузки формы
            var prepare = new PrepareForm();                                                        //Создаём диалог
            do {
                prepare.ShowDialog();                                                               //Показываем
                if (prepare.DialogResult != DialogResult.OK)
                    MessageBox.Show("Первоначальный треугольник некорректно задан", "Error",        //Уведомление об ошибке задания треуг-ка
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            } while (prepare.DialogResult != DialogResult.OK);                                      //Пока не получим возможный треуг-к
            fractal.Add(prepare.Triangle);                                                          //Когда возможный треуг. получен, он задаётся как изначальный
        }
    }
}