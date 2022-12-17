using System;
namespace ConsoleApp1
{
    class Person
    {
        private string Name { get; set; } = string.Empty;
        private int Age { get; set; }
        public Person(string name, int age)
        {
            if(name==null || name == "" || name.Length>32) 
            {
                throw new Exception("Name not valid");
            }
            if(age <= 0 || age > 128)
            {
                throw new Exception("Age is not valid");
            }
            Name = name;
            Age = age;
        }
        virtual public void Print()
        {
            Console.WriteLine("My name is " + Name + ", my age is " + Age);
        }
    }
    class Student : Person
    {
        private int Year { get; set; }
        private decimal Gpa { get; set; }
        public Student(string name,int age,int year, decimal gpa)
        :base(name,age)
        {
            if(year<=0 || year > 5)
            {
                throw new Exception("Year is not valid");
            }
            if (gpa < 0 || gpa > 4)
            {
                throw new Exception("Gpa is not valid");
            }
            Year = year;
            Gpa = gpa;
        }
        public override void Print()
        {
            Console.WriteLine("My name is " + Name + ", my age is " + Age + " and my gpa is " + Gpa);
        }
    }
    class Staff : Person
    {
        private decimal Salary { get; set; }
        private int JoinYear { get; set; }
        public Staff(string name,int age,decimal salary, int joinYear)
        :base(name,age)
        {
            if(salary<= 0 || salary > 120000)
            {
                throw new Exception("Salary is not valid");
            }
            if (joinYear > 21)
            {
                throw new Exception("Join Year is not valid");
            }
            Salary = salary;
            JoinYear = joinYear;
        }
        public override void Print()
        {
            Console.WriteLine("My name is " + Name + ", my age is " + Age + " and my salary is " + Salary);
        }
    }

    class Database
    {
        public List<Person> People { get; set; } = new List<Person>();
        public void AddStudent(Student student)
        {
            People.Add(student);
        }
        public void AddStaff(Staff staff)
        {
            People.Add(staff);
        }
        public void AddPerson(Person person)
        {
            People.Add(person);
        }
    }
}
