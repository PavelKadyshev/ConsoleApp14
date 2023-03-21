//Console.WriteLine("Задание 2");
//string[] allList = {"Рис","Макароны","Гречка","Лапша"};
//string[] list1 = { "Овес", "Геркулес", "Перец", "Лапша" };
//string[] list2 = { "Сахар", "Манка", "Пшено", "Соль" };
//string[] list3 = { "Рис", "Овес", "Соль", "Сахар" };
//string[] list4 = { "Овес", "Геркулес", "Макароны", "Сахар" };
//PrintSet(allList);
//PrintSet(list1);
//PrintSet(list2);
//PrintSet(list3);
//PrintSet(list4);
//Console.WriteLine("Входит во все множества:");
//PrintSet(list1.Intersect(list2).Intersect(list3).Intersect(list4));

//Console.WriteLine("НЕ входит ни в одно множества:");
//PrintSet(allList.Except(list1).Except(list2).Except(list3).Except(list4));
//Console.WriteLine("Входит в 3 множество");
//PrintSet(list2);
// private static void PrintSet(IEnumerable<string> set)
//{
//    foreach (string c in set)
//    {
//        Console.Write($"{c} ");
//    }
//    Console.WriteLine();
//}
class Program
{
    static void Main(string[] args)
    {
        string line = Console.ReadLine(); //исходная строка
        HashSet<char> setLine = TranslateLineToSet(line); //множество символов исходной строки
        PrintSet(setLine);
        HashSet<char> setDigit = new HashSet<char> { ',', '.', ':', ';' , '?','-', '!', 'A', 'B', 'C', 'D', 'E', 'F', '3', '4', '5', '6','7', '8', '9'};// множество символов, которые нужно найти
        PrintSet(setDigit);
        Console.WriteLine("Программа ищет пересечения");
        HashSet<char> newSet = setLine; // копия исходного множества
        newSet.IntersectWith(setDigit); //пересечение 
        PrintSet(newSet);
        Console.ReadKey();
    }
    private static HashSet<char> TranslateLineToSet(string word)
    {
        HashSet<char> setWord = new HashSet<char>();
        foreach (char c in word)
        {
            setWord.Add(c);
        }
        return setWord;
    }
    private static void PrintSet(HashSet<char> set)
    {
        foreach (char c in set)
        {
            Console.Write($"{c} ");
        }
        Console.WriteLine();
    }
}


