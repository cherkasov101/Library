 namespace Library
{
    public class Book
    {
        private static int nextId = 1; // id для следующей созданной книги
        private int id; // id книги
        private string title; // название книги 
        private string author; // автор книги
        private string description; // текстовое описание книги
        private bool status; // true если есть в наличие, false если на руках
        private int[] queue; // очередь желающих получить данную книгу (номера читательских билетов)
       
        // констуктор класс Book, создаёт объект данного класса
        public Book(string title, string author)
        {
            id = nextId;
            nextId++;
            this.title = title;
            this.author = author;
        }

        // свойство поля id, позволяет получать id книги
        public int Id { 
            get { return id; } 
        }

        // свойства поля name, позволяют получать название книги и устанавливать его
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        // свойства поля author, позволяют получать имя автора  книги и устанавливать его
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        // свойства поля description, позволяют олучить описание книги и добавить новое
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        // свойство поля status, позволяет получить текущий статус
        public bool Status
        {
            get { return status; }
        }
    }
}
