int Second (int a) {
    return (a % 100) / 10 ;
}

Console.WriteLine ("Введите треххначное число: ");

int numberUser = int.Parse(Console.ReadLine());

Console.WriteLine (Second (numberUser));