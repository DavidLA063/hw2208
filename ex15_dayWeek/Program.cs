Console.WriteLine ("Введите любое число: ");

int a = int.Parse (Console.ReadLine ());
int result = a % 10;

if (a < 100) {
    Console.WriteLine ("Третьей цифры нет");  
}
    else {
        while (a > 1000)
        {
            a = a / 10;
            result = a % 10;
        }
        Console.WriteLine ($"Третья цифра вашего числа {result}");
    }