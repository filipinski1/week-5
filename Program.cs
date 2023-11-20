using System;

namespace week_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person perrson = new Person
            {
                Name = "Philip Zilkovskyi",
                Email = "fil.zilkovskyi@gmailo.com"
            };
            Student student = new Student("Mark", "Math");
            student.DoHomework();


            Mentor mentor = new Mentor("Alex", "Math");
            mentor.CheckHomework();

            book myBook = new book("Harry Potter", 444);
            myBook.Display();

            chair mychair = new chair(33, 10);
            mychair.Display();

            computer mycomputer = new computer(100, "black");
            mycomputer.Display();

            window mywindow = new window(33, 44);
            mywindow.Display();
            tv mytv = new tv(400, "black");
            mytv.Display();



        }
    }
    public class Person
    {
        //fields
        public string Name { get; set; }

        public string Email { get; set; }

        public Person(string name = "", string email = "")
        {
            Name = name;
            Email = email;
        }



        public void Display()
        {
            Console.WriteLine($"Name: {Name} {Email}");

        }

      
    }
    public class Student
    {

        public string NameStudent { get; set; }
        public string ClassHomework { get; set; }

        public Student(string nameStudent, string classHomework)
        {
            NameStudent = nameStudent;
            ClassHomework = classHomework;

        }
        public void DoHomework()
        {
            Console.WriteLine($"{NameStudent} is doing homework");
        }
           
      
    }
    public class Mentor
    {
        public string NameMentor { get; set; }
        public string ClassTeaching { get; set; }   

        public Mentor (string nameMentor, string classTeaching)
        {
            NameMentor = nameMentor;
            ClassTeaching = classTeaching;
        }
        public void CheckHomework()
        {
            Console.WriteLine($"{NameMentor} will check your homework asap");
        }
    }

    class book
    {
        public string NameBook { get; set; }
        public int Pages { get; set; }

        public book(string namebook, int pages)
        {
            NameBook = namebook;
            Pages = pages;
        }
        public void Display()
        {
            Console.WriteLine($"Name: {NameBook} Pages: {Pages}");
        }
      
    }
    class chair
    {
        public int Height { get; set; }
        public int Weight { get; set; }
        public chair(int height, int weight)
        {
            Height = height;
            Weight = weight;
        }
        public void Display()
        {
            Console.WriteLine ($"Chair's Height = {Height}, Chair's Weight = {Weight}");
        }
       
    }
    class computer
    {
        int Cost;
        string Color;

        public computer(int cost, string color)
        {
            Cost = cost;
            Color = color;
        }
        public void Display()
        {
            Console.WriteLine($"My computer cost = {Cost}, and it's color {Color}");
        }

   
    }
    class window
    {
        int Height;
        int Width;
        public window (int height, int width)
        {
            Height = height;
            Width = width;

           
        }
        public void Display()
        {
            Console.WriteLine($"sizes of my window is Height={Height} and width={Width}");
        }
    }
   
   
   class tv
    {
        int Cost;
        string Color;

        public tv(int cost, string color)
        {
            Cost = cost;
            Color = color;
        }
        public void Display()
        {
            Console.WriteLine($"My TV's cost is {Cost} and its color {Color}");
        }
    }
   
}
