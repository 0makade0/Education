using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CWork
{
    class Program
    {

        static void Main()
        {
            List<Employee> peopleList = new List<Employee>();
            Random random = new Random();
            string[] name = new string[]
                {"Роман", "Александр", "Денис", "Алексей", "Евгений", "Джон,", "Никита", "Павел", "Константин", "Егор"};
            string[] secondName = new string[]
            {
                "Константинов", "Браду", "Павленко", "Стребков", "Усков", "Вик", "Петров", "Иванов", "Пушкин",
                "Достоевский"
            };
            string[] patronymic = new string[]
            {
                "Артёмович", "Денисович", "Алексеевич", "Дмитриевич", "Александрович", "Никитович", "Александрович",
                "Константинович", "Вадимович", "Евгеньевич"
            };
            string[] department = new string[] {"Продаж", "Складской", "Аналитики"};
            int[] Number = new int[15];
            Employee people;
            int count;
            int choice;
            while (true)
            {
                try
                {
                    for (int i = 0; i < 15; i++)
                    {
                        count = 1;
                        do
                        {
                            var numberPhone = random.Next(101, 116);
                            if (!((IList) Number).Contains(numberPhone))
                            {
                                people = new Employee(i + 1, name[random.Next(0, 10)], secondName[random.Next(0, 10)],
                                    patronymic[random.Next(0, 10)], department[random.Next(0, 3)], numberPhone);
                                peopleList.Add(people);
                                Number[i] = numberPhone;
                                count = 0;
                            }
                        } while (count == 1);
                    }

                    Console.WriteLine(
                        $"{"Id",-5}{"Name",-15}{"SecondName",-15}{"Patronymic",-15}{"Department",-12}{"Number"}");
                    foreach (Employee f in peopleList)
                    {
                        f.Show();
                    }

                    Console.Write("По какому номеру столбца сортируем список? \nОтвет: ");
                    choice = Int32.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            peopleList.Sort((a, b) => a.Id.CompareTo(b.Id));
                            break;
                        case 2:
                            peopleList.Sort((a, b) => a.Name.CompareTo(b.Name));
                            break;
                        case 3:
                            peopleList.Sort((a, b) => a.SecondName.CompareTo(b.SecondName));
                            break;
                        case 4:
                            peopleList.Sort((a, b) => a.Patronymic.CompareTo(b.Patronymic));
                            break;
                        case 5:
                            peopleList.Sort((a, b) => a.Department.CompareTo(b.Department));
                            break;
                        case 6:
                            peopleList.Sort((a, b) => a.Number.CompareTo(b.Number));
                            break;
                    }

                    Console.WriteLine();
                    Console.WriteLine($"{"Id",-5}{"Name",-15}{"SecondName",-15}{"Patronymic",-15}{"Department",-12}{"Number"}");
                    foreach (Employee f in peopleList)
                    {
                        f.Show();
                    }
                    Console.Write("Введите номер телефона рабочего: ");
                    choice = Int32.Parse(Console.ReadLine());
                    List<Employee> number = peopleList.Where(x => x.Number.Equals(choice)).ToList();
                    Console.WriteLine("Рабочий с таким номером телефона существует? - " + (number.Count > 0));
                    if (number.Count > 0)
                    {
                        Console.WriteLine($"{"Id",-5}{"Name",-15}{"SecondName",-15}{"Patronymic",-15}{"Department",-12}{"Number"}");
                        foreach (Employee e in number)
                        {
                            if (e.Number == choice)
                                e.Show();
                        }
                    }
                    Console.WriteLine("Хотите повторить?\n1 - Да;\nДругое число - Нет");
                    int s = int.Parse(Console.ReadLine());
                    if (s == 1)
                    {
                        Console.Clear();
                        Main();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                    Main();
                }
            }
        }
    }
}