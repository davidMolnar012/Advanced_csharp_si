namespace CreateClass
{
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
}