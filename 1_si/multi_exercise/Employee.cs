namespace CreateClass
{
    class Employee : Person
    {
        public int Salery { get; set; }
        public string Profession { get; set; }
        public Room Room { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\n" + "Salery: " + Salery + " Profession: " + Profession + " Room id: " + Room.Id;
        }

        static int Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Jane Austen";
            employee.Gender = Gender.FEMALE;
            employee.Birthdate = "1775.12.16";
            employee.Profession = "novelist";
            employee.Salery = 200;
            employee.Room = new Room();
            System.Console.WriteLine(employee.ToString());
            
            return 0;
        }
    }
}
