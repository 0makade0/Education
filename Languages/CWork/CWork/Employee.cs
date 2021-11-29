using System;
namespace CWork
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Patronymic { get; set; }
        public string Department { get; set; }
        public int Number { get; set; }
        public Employee(int id, string name, string SecondName,string Patronymic,string Department, int Number)
        {
            Id = id;
            Name = name;
            this.SecondName = SecondName;
            this.Patronymic = Patronymic;
            this.Department = Department;
            this.Number = Number;
        }
        public void Show()
        {
            Console.WriteLine($"{Id,-5}{Name,-15}{SecondName,-15}{Patronymic,-15}{Department,-12}{Number}");
        }
    }
}