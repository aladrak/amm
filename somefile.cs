// ЛР-2 Вариант 5
//Класс - Строка. Дополнительно перегрузить следующие операции:
// < - сравнения строк по длине слов;
// + добавления числа к строке;
// - удаление последнего символа в строке;
// * – замена всех символов в строке на заданный.
//Методы расширения:
// 1) Проверка наличия в строке заданных символов
// 2) Удаление знаков препинания из строки
using System.Diagnostics.Metrics;
using System.Reflection;

class SomeString(string _s)
{
    public string Str { get => _s; set => _s = value; }
    public int Length { get => _s.Length; }
    // < - сравнения строк по длине слов;
    public static bool operator >(SomeString a, SomeString b) => a.Length > b.Length;
    public static bool operator <(SomeString a, SomeString b) => a.Length < b.Length;
    // + добавления числа к строке;
    public static SomeString operator +(SomeString a, int b) => new SomeString(string.Join(a.Str, b));
    // - удаление последнего символа в строке;
    public static SomeString operator -(SomeString a) => new SomeString(a.Str[..^1]);
    // * – замена всех символов в строке на заданный.
    public override string ToString() => Str;
}
class Programm
{
    // 1. Создать заданный в варианте класс. Определить в классе необходимые
    //  методы, конструкторы, индесаторы и заданные перегруженные
    //  операции.Написать программу тестирования, в которой проверяется
    //  использование перегруженных операций.
    //2. Создать статический класс, содержащий метод расширения для типа string
    //и вашего типа из задания 1.
    static void Main()
    {
        var s = new SomeString("Hello");
        Console.WriteLine(s);
        Console.WriteLine(-s);
    }
}