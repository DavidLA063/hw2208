int [] array = {1, 2, 3, 4, 5, 6, 7};

Console.WriteLine ("Введите число ");

int day = int.Parse(Console.ReadLine());

if (day==array[0] || day==array[1] || day==array[2] || day==array[3] || day==array[4])
    Console.WriteLine("нет");
    else {
    Console.WriteLine("да");
}