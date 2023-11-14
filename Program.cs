using System;

//brief Родительский класс, в данном классе указываются основные параметры, при помощи которых можно расчитать атаку, имя, уровень героя
//btief метод IComparable описывает операцию сравнения
public class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Level { get; set; }
    public Person(string name, int level)
{
    Name = name;
    Level = level;
}

//brief Выводит уровень героя
public int CompareTo(Person other)
{
    return Level.CompareTo(other.Level);
}

//brief Выводит метод атаки героя
public void Attack()
{
    Console.WriteLine($"{Name} атакует противника");
}

//brief Выводит метод повышения уровня героя
public void LevelUp()
{
    Level++;
}

//brief Выводит защищающуюся сторону
public void Defend()
{
    Console.WriteLine($"{Name} защищается от атаки");
}

//brief Выводит основную информацию о герое
public void DisplayInfo()
{
    Console.WriteLine($"Имя героя: {Name}");
    Console.WriteLine($"Уровень: {Level}");
}
}

class Program
{
static void Main(string[] args)
{
    //brief Создание героев
        Person fighter = new Person("Боец", 4);
        Person knight = new Person("Рыцарь", 5);
        fighter.Attack();
        knight.Defend();

        fighter.LevelUp();
        knight.DisplayInfo();

        //brief метод сравнения героев по силе
        int result = fighter.CompareTo(knight);
        if (result > 0)
        {
             Console.WriteLine($"{fighter.Name} сильнее, чем {knight.Name}!");
        }
        else if (result < 0)
        {
             Console.WriteLine($"{knight.Name} сильнее, чем {fighter.Name}!");
        }
        else 
        {
            Console.WriteLine($"{fighter.Name} и {knight.Name} одинаковы по силе!");
        }

} 
}