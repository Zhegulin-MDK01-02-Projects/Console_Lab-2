//Ответить названием геометрического объекта с указанным кол-вом вершин
Console.WriteLine("Введите число");
int storona = Convert.ToInt32(Console.ReadLine());
switch (storona)
{
    case 0:
        Console.WriteLine("Круг");
        break;
    case 1:
        Console.WriteLine("Луч");
        break;
    case 2:
        Console.WriteLine("Отезок");
        break;
    case 3:
        Console.WriteLine("Треугольник");
        break;
    case 4:
        Console.WriteLine("Квадрат");
        break;
    case 5:
        Console.WriteLine("Пентагон");
        break;
    case 6:
        Console.WriteLine("Гексагон");
        break;
    case 7:
        Console.WriteLine("Гептагон");
        break;
    case 8:
        Console.WriteLine("Октагон");
        break;
    default:
        Console.WriteLine("Введите число от 0 до 8");
        break;
}