class Person
{
	public string Name { get; set; }
	public string Birthdate { get; set; }
    public Gender Gender { get; set; }

    public override string ToString()
    {
		return "Name: " + Name + " Birthdate: " + Birthdate + " Gender: " + Gender.ToString();
    }
}

enum Gender
{
	MALE,
	FEMALE
}

class Run
{
	public static int Main()
    {
		Person person = new Person();
		person.Name = "John";
		person.Birthdate = "1984.04.20";
		person.Gender = Gender.MALE;
        System.Console.WriteLine(person.ToString());
        System.Console.WriteLine();

		return 0;
    }
}
