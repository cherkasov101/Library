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
        private Dictionary<string, int> titleCatalog; // словарь для поиска id книги по названию
        private Dictionary<string, int> authorCatalog; // словарь для поиска id книги по автору

        // конструктор, создаёт объект класса Catalog, загружает данные из файла
        public Catalog()
        {

        }

        // поиск книги по названию
        public int GetByTitle(string title)
        {
            return titleCatalog[title];
        }

        // поиск книги по автору
        public int GetByAuthor(string author)
        {
            return authorCatalog[author];
        }

        // сохранение книг в файл
        public void SaveData()
        {

        }
    }
}
