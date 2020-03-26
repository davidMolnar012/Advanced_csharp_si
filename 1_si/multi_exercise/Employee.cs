using System;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        public int Salery { get; set; }
        public string Profession { get; set; }
        public Room Room { get; set; }
        public Employee(string name, Gender gender, string birthdate, string profession, int salery)
        {
            Name = name;
            Gender = gender;
            Birthdate = birthdate;
            Profession = profession;
            Salery = salery;
        }
        public override string ToString()
        {
            return base.ToString() + "\n" + "Salery: " + Salery + " Profession: " + Profession + " Room id: " + Room.Id;
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.Id);
            return newEmployee;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee Kovacs = new Employee("Géza",Gender.MALE, DateTime.Now.ToString(), "léhűtő", 1000);
            Kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.Id = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();
        }
    }
}
