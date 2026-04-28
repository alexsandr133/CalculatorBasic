// See https://aka.ms/new-console-template for more information
Employee employee1 = new Employee("александр","захарченко",155000,"программист по с++");
employee1.ReturnInformation();

public class Employee
{
  
    public string name;
    public string patronymic;
    public string post;
    private int _salary;


    //парамаетр зарплаты
    public int Salary
    {
        get => _salary;
        private set
        {
            if (value < 48000) _salary = 48000;
            else if (value > 255000) _salary = 255000;
            else _salary = value;
        }
    }
    public Employee(string name, string patronymic,int _salary,string post)
    {
        this.Salary = _salary;
        this.name = name;
        this.post = post;
        this.patronymic = patronymic;

    }
    public void ReturnInformation()
    {
        Console.WriteLine($"ваша зарплата\t {Salary}, \tваше имя\t{name}, \tваша фамилия\t{patronymic},\tваша должность \t{post}");
    }
}
    
