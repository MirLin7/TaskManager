using System;
using System.Security.Cryptography.X509Certificates;
namespace TaskManager
{
    class Program
    {
        static Manager manager = new Manager();
        static void Main()
        {
            Console.WriteLine("Добро пожаловать!\nTask Manager - программа которая облегчит жизнь, распределяя нагрузки." +
                "\n\nВыбери что хочешь сделать со своими задачами:");
            while (true)
            {
                Console.Write("\n1.Добавить\n2.Посмотреть\n\n Выбор:");
                Input();
            }
        }
        public static void Input()
        {
            byte input = Convert.ToByte(Console.ReadLine());
            manager.Choise(input);
        }
        public static void Creat()
        {
            Console.WriteLine("\n1. Суть задачи:");
            string description = Console.ReadLine();

            Console.WriteLine("2. Короткое название задачи:");
            string name = Console.ReadLine();

            bool fav = true;
            bool IsFavourite = false;
            while (fav == true)
            {
                Console.WriteLine("3. В Фавориты? Да/Нет:\n");
                string Favourite = Console.ReadLine();
                if (Favourite == "Да")
                {
                    IsFavourite = true;
                    fav = false;
                }
                else if (Favourite == "Нет")
                {
                    IsFavourite = false;
                    fav = false;
                }
                else
                { fav = true; }
            }
            bool IsDone = false;
            manager.Created(description, name, IsFavourite, IsDone);
        }







        public static void Change(byte num)
        {
            Console.WriteLine();
            Console.WriteLine("1) Редактировать\n2) Удалить\n3) Вернуться\n4) Выполнено/Невыполнено\n\n Выбор: ");
            Byte SecondInput = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();
            manager.SecondChoise(num, SecondInput);
        }
        public static void Betrayal(byte num)
        {
            Console.Write("Что изменить?\n1) Описание\n2) Имя\n3) Фаворит\n\n Выбор: ");
            Byte EditInput = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();
            manager.Edit(EditInput, num);
        }
    }
}