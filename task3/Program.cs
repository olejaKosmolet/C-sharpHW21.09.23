// Task 15
Console.Write("Для проверки выходного дня введите число соответствующее дню недели: ")

int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("нет");
        break;
    case 6:
    case 7:
        Console.WriteLine("да");
        break;
}