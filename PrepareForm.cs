using static System.Math;                                                               //Использование класса мат. вычислений

namespace Laba {
    public partial class PrepareForm : Form {                                           //Класс формы
        public Triangle Triangle { get; private set; }                                  //Первоначальный треугольник
        public PrepareForm() {                                                          //Конструктор
            InitializeComponent();                                                      //Отрисовка интерфейса
        }
        private bool Check(double[] sides) {                                            //Проверка треугольника на возможность
            return (sides[0] < (sides[1] + sides[2]))
                && (sides[1] < (sides[0] + sides[2]))
                && (sides[2] < (sides[1] + sides[0]));
        }

        private void accept_Click(object sender, EventArgs e) {                         //Обработка кнопки
            var sides = new double[] {                                                  //Расчёт массива сторон треуг-ка
                Sqrt(Pow(((double)setBx.Value) - ((double)setAx.Value), 2) + Pow((((double)setBy.Value) - ((double)setAy.Value)), 2)),
                Sqrt(Pow(((double)setCx.Value) - ((double)setBx.Value), 2) + Pow(((double)setCy.Value) - ((double)setBy.Value), 2)),
                Sqrt(Pow(((double)setCx.Value) - ((double)setAx.Value), 2) + Pow(((double)setCy.Value) - ((double)setAy.Value), 2))
            };

            this.DialogResult = (Check(sides)) ? DialogResult.OK : DialogResult.Cancel; //Результат зависит от возможности треуг-ка
            this.Triangle = new(((float)setAx.Value, (float)setAy.Value),               //Иниц-ия треуг-ка
                ((float)setBx.Value, (float)setBy.Value),
                ((float)setCx.Value, (float)setCy.Value));
        }
    }
}
