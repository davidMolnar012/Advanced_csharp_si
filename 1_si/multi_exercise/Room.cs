namespace CreateClass
{
    class Room
    {
        public int Id { get; private set; }
        private static int counter = 0;

        public Room()
        {
            Id = counter;
            counter++;
        }
    }
}
