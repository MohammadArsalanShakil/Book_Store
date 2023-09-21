namespace Book_Store.Classes
{
    public class Book
    {
        int id;
        string name;
        string genre;

        public Book() { }

        public Book(int id, string name, string genre)
        {
            Id = id;
            Name = name;
            Genre = genre;
        }

        public string Name { get => name; set => name = value; }
        public string Genre { get => genre; set => genre = value; }
        public int Id { get => id; set => id = value; }
    }
}
