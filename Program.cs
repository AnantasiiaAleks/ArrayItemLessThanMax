const int MaxChars = 3;

string[] example1 = {"Hello", "2", "world", ":-)"};

string[] example2 = {"1234", "1567", "-2", "computer science"};

string[] example3 = {"Russia", "Denmark", "Kazan"};

Console.WriteLine("Привет, я дружелюбная программа для выбора значений " +
    "твоих массивов с определенным количеством символов.");

ArrayMaster.PrintArray(example1, "Пример 1. Массив из всех значений: ");
string[] resultExample1 = ArrayMaster.NewArrayStringsNoLongerThan(example1, MaxChars);
ArrayMaster.PrintArray(resultExample1, "Пример 1. Новый массив из значений, состоящих не более, чем из 3 сиволов: ");
Console.WriteLine("Нажми любую клавишу для продолжения");
Console.ReadKey();

ArrayMaster.PrintArray(example2, "Пример 2. Массив из всех значений: ");
string[] resultExample2 = ArrayMaster.NewArrayStringsNoLongerThan(example2, MaxChars);
ArrayMaster.PrintArray(resultExample2, "Пример 2. Новый массив из значений, состоящих не более, чем из 3 сиволов: ");
Console.WriteLine("Нажми любую клавишу для продолжения");
Console.ReadKey();

ArrayMaster.PrintArray(example3, "Пример 3. Массив из всех значений: ");
string[] resultExample3 = ArrayMaster.NewArrayStringsNoLongerThan(example3, MaxChars);
ArrayMaster.PrintArray(resultExample3, "Пример 3. Новый массив из значений, состоящих не более, чем из 3 сиволов: ");
Console.WriteLine("Нажми любую клавишу для продолжения");
Console.ReadKey();

Console.WriteLine("А теперь ты можешь проверить, как я работаю с твоими данными. " +
    "Скажи, сколько элементов массива ты собираешься придумать?");
Console.WriteLine("Напиши целое положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= 0)
{
    Console.WriteLine("Неверное значение. Попробуй в другой раз ;-)");
    Console.WriteLine("Нажми любую клавишу для завершения программы");
    Console.ReadKey();
}
else
{
    Console.WriteLine("Напиши мне значения для заполнения " +
        "твоего собственного массива. После ввода каждого значения жми Enter.");
    string[] example4 = new string[n];
    for (int i = 0; i < n; i++)
    {
        example4[i] = Console.ReadLine();
    }

    ArrayMaster.PrintArray(example4, "Твой массив получился такой: ");
    string[] resultExample4 = ArrayMaster.NewArrayStringsNoLongerThan(example4, MaxChars);
    ArrayMaster.PrintArray(resultExample4, "Новый массив из значений, состоящих не более, чем из 3 сиволов: ");
    Console.WriteLine("Нажми любую клавишу для завершения работы программы. Пока-пока.");
    Console.ReadKey();
}