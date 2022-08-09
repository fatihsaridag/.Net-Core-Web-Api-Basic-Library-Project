using BookStore.Data.Interfaces;
using BookStore.Data.Models;
using BookStore.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        //public List<Book> books = new List<Book>()
        //{
        //    new Book {Id=1, Title="Kürk Mantolu Madonna" , Author= "Sabahattin Ali" , PublicationYear= 1943, IsAvailable=false ,CallNumber = "F HAWKI" },
        //    new Book {Id=2, Title="Hayvan Çiftliği" , Author= "George Orwell" , PublicationYear= 2000, IsAvailable=true ,CallNumber = "G HAWKI" },
        //    new Book {Id=3, Title="Bilinmeyen Bir Kadının Mektubu" , Author= "Stefan Zweig" , PublicationYear= 2002, IsAvailable=true ,CallNumber = "Z HAWKI" },
        //    new Book {Id=2, Title="Küçük Prens" , Author= "Antonie de Seint" , PublicationYear= 1980, IsAvailable=true ,CallNumber = "A HAWKI" },
        //    new Book {Id=2, Title="Amok Koşucusu" , Author= "Stefan Zweig" , PublicationYear= 1996, IsAvailable=true ,CallNumber = "Z HAWKI" }


        //};
        private BookRepository books = new BookRepository();



        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            return books.GetAllBooks();
        }


        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            var book = books.GetBook(id);
            if (book == null)
            {
                return NotFound();

            }
            return book;
        }


    }
}
