using System.Collections;
using B_R_Game_3;

ArrayList List = new ArrayList();


List<Employee> emplist = new List<Employee>()
{
    new Employee("Marina", "woman", 4500, 1, "yes"),
    new Employee("Mark", "men", 5500, 2, "yes"),
    new Employee("Markis", "men", 7500, 3, "yes"),
    new Employee("Danila", "men", 3500, 4, "no"),
    new Employee("Happy", "men", 5500, 5, "yes"),
    new Employee("Sarina", "woman", 5700, 6, "yes"),
    new Employee("Nastya", "woman", 4350, 7, "yes"),
    new Employee("Sasha", "woman", 5800, 8, "yes"),
    new Employee("Adolf", "men", 9500, 9, "Too good"),
    new Employee("Dream", "men", 8200, 10, "no"),
};

void methodall()
{
    foreach (Employee emp in emplist)
    {
        Console.WriteLine(emp.fio + "");
        Console.WriteLine(emp.Gender + "");
        Console.WriteLine(emp.Salary + "\n");
    }
}
methodall();
Console.WriteLine("Hi bro nice Ass");

