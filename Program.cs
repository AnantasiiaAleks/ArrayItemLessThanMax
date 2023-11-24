const int MaxChars = 3;

string[] example1 = {"Hello", "2", "world", ":-)"};

string[] example2 = {"1234", "1567", "-2", "computer science"};

string[] example3 = {"Russia", "Denmark", "Kazan"};

Console.WriteLine("Привет, я дружелюбная программа для выбора значений " +
    "твоих массивов с определенным количеством символов. Начнем?");

ArrayMaster.PrintArray(example1, "Пример 1. Массив из всех значений: ");
string[] resultExample1 = ArrayMaster.NewArrayStringsNoLongerThan(example1, MaxChars);
ArrayMaster.PrintArray(resultExample1, "Пример 1. Новый массив из значений, состоящих не более, чем из 3 сиволов: ");

ArrayMaster.PrintArray(example2, "Пример 2. Массив из всех значений: ");
string[] resultExample2 = ArrayMaster.NewArrayStringsNoLongerThan(example2, MaxChars);
ArrayMaster.PrintArray(resultExample2, "Пример 2. Новый массив из значений, состоящих не более, чем из 3 сиволов: ");

ArrayMaster.PrintArray(example3, "Пример 3. Массив из всех значений: ");
string[] resultExample3 = ArrayMaster.NewArrayStringsNoLongerThan(example3, MaxChars);
ArrayMaster.PrintArray(resultExample3, "Пример 3. Новый массив из значений, состоящих не более, чем из 3 сиволов: ");