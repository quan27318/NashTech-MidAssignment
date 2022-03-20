namespace BackEnd.Models{
    public class Book{
        public int BookId{ get; set; }
        public string BookName{ get; set; }
        public string BookType{ get; set; }
        public string Author{ get; set; }
        public int CategoryId{ get; set; }
    }
}