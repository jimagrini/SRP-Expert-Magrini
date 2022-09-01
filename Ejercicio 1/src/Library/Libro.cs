using System;

namespace SRP
{
    public class Book
    {
        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        
        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
    }
    public class ShelveBook
    {
        public string Book {get; set;}
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }
        public ShelveBook(string book, String sector, String shelve)
        {
            this.Book=book;   
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
        /*En mi opinion se viola el principio SRP debido a que la
        misma clase se encarga de almacenar tanto los datos del libro como 
        los datos de la ubicacion del mismo. La forma correcta sería establecer
        dos clases, una encargada de almacenar información del libro, y otra
        encargada de la ubicacion del mismo. La ubicación del libro no deberia de 
        repercutir sobre la clase Book entera que también esta a cargo de conocer
        los datos del libro.
        */
    }
}

