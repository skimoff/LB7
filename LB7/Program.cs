
using LB7.Interfaces.InterfaceForTask3;
using LB7.Task3;

namespace LB7;

class Program
{
    static void Task1()
    {
        // Створення об'єкта Person
        Person person = new Person("Іван", "Петренко", new DateTime(1990, 5, 20));

        // Створення кількох пристроїв
        Device d1 = new Device("Мишка", 250.0, new DateTime(2021, 1, 10));
        Device d2 = new Device("Клавіатура", 500.0, new DateTime(2022, 3, 15));
        Device d3 = new Device("Монітор", 3000.0, new DateTime(2023, 2, 20));

        // Створення комп'ютера
        Computer comp = new Computer(person, TypeOfWork.Business, "192.168.0.1", new Device[] { d1, d2 });

        Console.WriteLine("=== ПЕРШИЙ КОМП'ЮТЕР ===");
        Console.WriteLine(comp.ToShortString());

        // Додавання ще одного пристрою
        comp.Add(d3);

        Console.WriteLine("\n=== ПІСЛЯ ДОДАВАННЯ ПРИСТРОЮ ===");
        foreach (Device d in comp)
        {
            Console.WriteLine(d);
        }

        // Сортування пристроїв (якщо Device реалізує IComparable)
        Array.Sort(comp.Device);

        Console.WriteLine("\n=== ПІСЛЯ СОРТУВАННЯ ===");
        foreach (Device d in comp)
        {
            Console.WriteLine(d);
        }

        // Збереження у файл
        string fileName = "in.txt";
        comp.Save(fileName);
        Console.WriteLine($"\nДані збережено у файл: {fileName}");

        // Копіювання перших двох пристроїв у новий комп'ютер
        Device[] firstTwo = new Device[2];
        Array.Copy(comp.Device, firstTwo, 2);
        Computer compCopy = new Computer(person, TypeOfWork.Home, "192.168.0.2", firstTwo);

        Console.WriteLine("\n=== СКОПІЙОВАНИЙ КОМП'ЮТЕР ===");
        Console.WriteLine(compCopy.ToShortString());

        // Збереження копії у файл
        string copyFileName = "out.txt";
        compCopy.Save(copyFileName);
        Console.WriteLine($"Копія збережена у файл: {copyFileName}");
    }

    static void Task2()
    {
        
    }
    
    static void Task3()
    { 
        ICipher a = new ACipher();
        string sd = "АБВ";
        string encode = a.encode(sd);
        Console.WriteLine(encode);
        string dec = a.decode(sd);
        Console.WriteLine(dec);
        
        
        ICipher b = new BCipher();
        string ds = "впаб";
        string encode2 = b.encode(ds);
        Console.WriteLine(encode2);
        string dec2 = b.decode(encode2);
        Console.WriteLine(dec2);
    }
    
    
    
    
    static void Main(string[] args)

    {
        Task1();
        //Task3();
        Console.ReadKey();
    }
}