using System;
#region FirstTask
//public class Hometask
//{
//    public static void Main(string[] args)
//    {
//        Car car = new Car(0);

//        int fuel = int.Parse(Console.ReadLine());
//        if (car.Refuel(fuel))
//        {
//            car.Drive();
//        }
//    }

//    public interface IVehicle
//    {
//        void Drive();
//        bool Refuel(int amount);
//    }

//    public class Car : IVehicle
//    {
//        public int Fuel { get; set; }

//        public Car(int fuel)
//        {
//            Fuel = fuel;
//        }

//        public void Drive()
//        {
//            if (Fuel > 0)
//            {
//                Console.WriteLine("Driving");
//            }
//            else
//            {
//                Console.WriteLine("Not fuel");
//            }
//        }

//        public bool Refuel(int amount)
//        {
//            Fuel += amount;
//            return true;
//        }
//    }
//}
#endregion
#region SecondTask
//public class Task2
//{
//    public static void Main(string[] args)
//    {
//        int total = 3;
//        Person[] people = new Person[total];

//        for (int i = 0; i < total; i++)
//        {
//            if (i == 0)
//            {
//                people[i] = new Teacher(Console.ReadLine());
//            }
//            else
//            {
//                people[i] = new Student(Console.ReadLine());
//            }
//        }

//        for (int i = 0; i < total; i++)
//        {
//            if (i == 0)
//            {
//                ((Teacher)people[i]).Explain();

//            }
//            else
//            {
//                ((Student)people[i]).Study();
//            }
//        }
//    }

//    public class Person
//    {
//        protected string Name { get; set; }

//        public Person(string name)
//        {
//            Name = name;
//        }

//        public override string ToString()
//        {
//            return "Salam, menim adim" + Name;
//        }

//        ~Person()
//        {
//            Name = string.Empty;
//        }
//    }

//    public class Teacher : Person
//    {
//        public Teacher(string name) : base(name)
//        {
//            Name = name;
//        }

//        public void Explain()
//        {
//            Console.WriteLine("Tedris edirem.");
//        }
//    }

//    public class Student : Person
//    {
//        public Student(string name) : base(name)
//        {
//            Name = name;
//        }

//        public void Study()
//        {
//            Console.WriteLine("Tehsil aliram.");
//        }
//    }
//}
#endregion
#region ThirdTask
//public class AbstractClasses
//{
//    public static void Main(string[] args)
//    {
//        Dog dog = new Dog();
//        dog.SetName(Console.ReadLine());
//        Console.WriteLine(dog.GetName());
//        dog.Eat();
//    }

//    public class Dog : Animal
//    {
//        public override void Eat()
//        {
//            Console.WriteLine("Eating");
//        }
//    }

//    public abstract class Animal
//    {
//        private string Name;

//        public void SetName(string name)
//        {
//            Name = name;
//        }

//        public string GetName()
//        {
//            return Name;
//        }

//        public abstract void Eat();
//    }
//}
#endregion
#region FourthTask
//public class secondtask
//{
//    public static void Main(string[] args)
//    {
//        int total = 5;
//        Person[] people = new Person[total];

//        for (int i = 0; i < total; i++)
//        {
//            people[i] = new Person(Console.ReadLine());
//        }

//        for (int i = 0; i < total; i++)
//        {
//            Console.WriteLine(people[i].ToString());
//        }
//    }

//    public class Person
//    {
//        public string Name { get; set; }

//        public Person(string name)
//        {
//            Name = name;
//        }

//        public override string ToString()
//        {
//            return "Salam, Menim adim "  + Name;
//        }

//        ~Person()
//        {
//            Name = string.Empty;
//        }
//    }
//}
#endregion