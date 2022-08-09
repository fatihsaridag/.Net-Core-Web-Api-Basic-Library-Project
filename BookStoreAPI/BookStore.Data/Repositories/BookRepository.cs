using BookStore.Data.Interfaces;
using BookStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.Repositories
{
    public class BookRepository : IBookRepository
    {

        public List<Book> books = new List<Book>()
        {
            new Book {Id=1, Title="Kürk Mantolu Madonna" , Author= "Sabahattin Ali" , PublicationYear= 1943, IsAvailable=false ,CallNumber = "F HAWKI" },
            new Book {Id=2, Title="Hayvan Çiftliği" , Author= "George Orwell" , PublicationYear= 2000, IsAvailable=true ,CallNumber = "G HAWKI" },
            new Book {Id=3, Title="Bilinmeyen Bir Kadının Mektubu" , Author= "Stefan Zweig" , PublicationYear= 2002, IsAvailable=true ,CallNumber = "Z HAWKI" },
            new Book {Id=2, Title="Küçük Prens" , Author= "Antonie de Seint" , PublicationYear= 1980, IsAvailable=true ,CallNumber = "A HAWKI" },
            new Book {Id=2, Title="Amok Koşucusu" , Author= "Stefan Zweig" , PublicationYear= 1996, IsAvailable=true ,CallNumber = "Z HAWKI" }


        };

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book GetBook(int id)
        {
            return books.FirstOrDefault(x => x.Id == id);
        }
    }
}
