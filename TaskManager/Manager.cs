using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
namespace TaskManager
{
    class Manager
    {
        List<Task> tasks = new List<Task>();
        public void Choise(byte input)
        {
            switch (input)
            {
                case 1: Program.Creat(); break;
                case 2: ShowAll(); break;
                default: Console.WriteLine("Выбор от 1 до 2"); break;
            }
        }
        public void Created(string description, string name, bool IsFavourite, bool IsDone)
        {
            Task newTask = new Task(description, name, IsFavourite, IsDone);
            tasks.Add(newTask);
            tasks.Sort((a,b) => b.IsFavourite.CompareTo(a.IsFavourite));
        }
        public void ShowAll()
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"{i + 1}) {tasks[i].name}");
                if (tasks[i].IsFavourite == true)
                {
                    Console.WriteLine(new string('-', $"{i + 1}) {tasks[i].name}".Length));
                }
                Console.WriteLine(tasks[i].Createdat);
                if (tasks[i].IsDone == true)
                {
                    Console.WriteLine("Выполнено");
                }
            }
            if (tasks.Count == 0) { Console.WriteLine("\nПусто"); }
            else if (tasks.Count > 0) { Reveal(); }
        }
        public void Reveal()
        {
            Console.WriteLine();
            Console.Write("Выбери задачу: ");
            while (true)
            {
                byte num = Convert.ToByte(Console.ReadLine());
                if (num >= 1 && num <= tasks.Count)
                {
                    Console.WriteLine();
                    Console.WriteLine(tasks[num - 1].description);
                    Program.Change(num);
                    break;
                }
                else { Console.Write("Нет такого номера. Попробуй снова: "); }
            }
        }







        public void SecondChoise(byte num, byte SecondInput)
        {
            switch (SecondInput)
            {
                case 1: Program.Betrayal(num); break;
                case 2: tasks.RemoveAt(num - 1); break;
                case 3: Console.WriteLine("\n\nВыбери что хочешь сделать со своими задачами:"); break;
                case 4:
                    if (tasks[num - 1].IsDone == false) { tasks[num - 1].IsDone = true; }
                    else if (tasks[num - 1].IsDone == true) { tasks[num - 1].IsDone = false; }
                    break;
                default: Console.WriteLine("Выбор от 1 до 3"); break;
            }
        }
        public void Edit(Byte EditInput, byte num)
        {
            switch (EditInput)
            {
                case 1: tasks[num - 1].description = Console.ReadLine(); break;
                case 2: tasks[num - 1].name = Console.ReadLine(); break;
                case 3: if (tasks[num - 1].IsFavourite == false) { tasks[num - 1].IsFavourite = true; }
                    else if (tasks[num - 1].IsFavourite == true) { tasks[num - 1].IsFavourite = false; } break;
                default: Console.WriteLine("Выбор от 1 до 3"); break;
            }
        }
    }
}