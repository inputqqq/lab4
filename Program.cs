class Program
{
    static void Main()
    {
        Console.WriteLine("==== Демонстрация нового функционала ====");


        // ---------------------------------------------
        // 1. Виртуальные функции + полиморфизм
        // ---------------------------------------------


        Challenge ch = new Challenge("C1", "Daily Run", "Run 1 km");
        Challenge adv = new AdvancedChallenge("C2", "Swim", "Swim 500m", 3);


        Console.WriteLine("\nВызов виртуальной функции через базовый класс:");
        ch.ShowChallengeInfo();


        Console.WriteLine("\nВызов виртуальной функции через ссылку на производный объект:");
        Challenge ref2 = adv;
        ref2.ShowChallengeInfo(); // вызывается ПЕРЕГРУЖЕННЫЙ метод




        // ---------------------------------------------
        // 2. Protected — демонстрация
        // ---------------------------------------------
        Console.WriteLine("\nAdvancedChallenge имеет доступ к protected Participants.");




        // ---------------------------------------------
        // 3. Клонирование — поверхностное и глубокое
        // ---------------------------------------------


        Achievement a1 = new Achievement("A1", "Wake Up", "Wake early", 50);
        Achievement shallow = (Achievement)a1.Clone();
        Achievement deep = a1.DeepClone();


        Console.WriteLine("\nПоверхностное и глубокое клонирование выполнено.");




        // ---------------------------------------------
        // 4. Множественное наследование (от класса и интерфейса)
        // ---------------------------------------------


        IResettable r = new AdvancedChallenge("C3", "Push Ups", "Do 20 push ups", 2);
        r.Reset();


        Console.WriteLine("\nМножественное наследование (класс + интерфейс) продемонстрировано.");




        // ---------------------------------------------
        // 5. Перегрузка виртуального метода (base + без base)
        // ---------------------------------------------


        Console.WriteLine("\nПерегрузка GetProgress():");
        Console.WriteLine($"Base: {ch.GetProgress("u1")}");
        Console.WriteLine($"Derived: {adv.GetProgress("u1")}");


        Console.WriteLine("\n=== КОНЕЦ ДЕМОНСТРАЦИИ ===");
    }
}