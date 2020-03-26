namespace CreateClass
{
    class Room
    {
        public int Id { get; set; }
        private static int counter = 0;
        public Room(int id)
        {
            Id = id;
        }
    }
}
