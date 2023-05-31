namespace Laba {
    public struct Triangle {                                                  //Структура треуголника
        private (float x, float y) A, B, C;                                     //Точки-вершины
        public Triangle((float, float) a, (float, float) b, (float, float) c) { //Конструктор
            A = a; B = b; C = c;                                                //Настройка вершин
        }
        public void Draw(in Graphics canvas, byte Scale) {                      //Отрисовка этого треугольника
            using (SolidBrush br = new(Color.Green)) {                          //Используя перо br
                canvas.FillPolygon(br, new PointF[] {                           //Рисуем полигон из точек
                    new(A.x * Scale, A.y * Scale),                              //Вершина А с попр. на масштаб
                    new(B.x * Scale, B.y * Scale),                              //Вершина В с попр. на масштаб
                    new(C.x * Scale, C.y * Scale)                               //Вершина С с попр. на масштаб
                });
            }                                                                   //Освобождаем ресурсы пера
        }
        public Triangle[] Separate() {                                          //Разделяем этот треугольник на 6 новых
            (float x, float y) d, e, f, g, h, k, l;                             //Точки разделения
            float c1 = 1f / 3, c2 = 2f / 3;                                     //Важные коэффициенты
            d = (c1*(B.x - A.x) + A.x, c1*(B.y - A.y) + A.y);
            e = (c2*(B.x - A.x) + A.x, c2*(B.y - A.y) + A.y);
            f = (C.x - c1*(C.x - A.x), c2*(B.y - C.y) + C.y);
            g = (C.x - c1*(C.x - B.x), c1*(B.y - C.y) + C.y);
            h = (c2 * (C.x - A.x) + A.x, A.y);
            k = (c1 * (C.x - A.x) + A.x, A.y);
            l = (B.x, c1 * (B.y - A.y) + A.y);
            return new Triangle[] {                                             //Возвращаем массив новых треугольников из комбинаций точек
                new(A, d, k), new(d, e, l), new(e, B, f),
                new(l, f, g), new(h, g, C), new(k, l, h)
            };
        }
    }
}
