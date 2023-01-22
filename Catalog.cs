using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Catalog
    {
        private Dictionary<int, Book> bookCatalog; // каталог книг
        private Dictionary<string, int> titleCatalog; //
        private Dictionary<string, int> authorCatalog; //

        // конструктор, создаёт объект класса Catalog
        public Catalog()
        {

        }

        //
        public int GetByTitle(string title)
        {
            return titleCatalog[title];
        }

        //
        public int GetByAuthor(string author)
        {
            return authorCatalog[author];
        }
    }
}
