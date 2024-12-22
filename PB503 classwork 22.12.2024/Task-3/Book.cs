using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_classwork_22._12._2024.Task_3
{
    public class Book
    {
        private static byte _id;
        public byte Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime PublicationYear { get; set; }
       
        public Book()
        {
            Id = ++_id;
            PublicationYear = DateTime.UtcNow.AddHours(4);
        }
    }
}
