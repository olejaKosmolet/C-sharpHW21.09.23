// Task13

int number = Convert.ToInt32(Console.ReadLine());
string result = number.ToString();
int num1;

if (number / 10 == 0 || number / 100 == 0)
{
    Console.WriteLine("Третьей цифры нет!");
}
else 
{
    num1 = (result[2] - '0');
    Console.WriteLine(num1);
}