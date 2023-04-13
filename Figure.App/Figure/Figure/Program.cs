using FigureLibrary;
using FigureLibrary.Figures;

IFigure Triangle1 = new Triangle(1, 1.5, 2); //стороны треугольника
                                             //(погрешность вычислений по умолчанию,
                                             //разряд округлений выходный значений определяется по погрешности вычислений)
Triangle1.Data((t) => Console.WriteLine(t));
Console.WriteLine($"Площадь треугольника: {Triangle1.Area()}.");

ITriangle Triangle2 = new Triangle(7, 7, 10, 0.000001); // стороны треугольника и погрешность вычислений
                                                        // (разряд округлений выходный значений определяется по погрешности вычислений)
Triangle2.Data((t) => Console.WriteLine(t));
Console.WriteLine($"Площадь треугольника: {Triangle2.Area()}.");
Console.WriteLine($"Признак прямоугольности треугольника: {Triangle2.IsRightTriangle()}.");

ITriangle Triangle3 = new Triangle(3, 4, 5, 0.000001, 4); // стороны треугольника, погрешность вычислений и разряд округлений выходный значений
Triangle3.Data((t) => Console.WriteLine(t));
Console.WriteLine($"Площадь треугольника: {Triangle3.Area()}.");
Console.WriteLine($"Признак прямоугольности треугольника: {Triangle3.IsRightTriangle()}.");

IFigure Circle1 = new Circle(1, 4); //радиус круга и разряд округлений выходный значений
                                    //(погрешность вычислений определяется по разряду округлений выходный значений)
Circle1.Data((t) => Console.WriteLine(t));
Console.WriteLine($"Площадь круга: {Circle1.Area()}.");

IFigure Circle2 = new Circle(7, 5, false); //радиус круга и разряд округлений выходный значений
                                           //(погрешность вычислений по умолчанию)
Circle2.Data((t) => Console.WriteLine(t));
Console.WriteLine($"Площадь круга: {Circle2.Area()}.");


#if false

//ошибочные вызовы
IFigure Circle01 = new Circle(-7);
IFigure Triangle01 = new Triangle(1, 2, 3);
IFigure Triangle02 = new Triangle(-1, -2, -3);
IFigure Triangle03 = new Triangle(3, 4, 5, -2);
IFigure Triangle04 = new Triangle(3, 4, 5, -0.1);

#endif
