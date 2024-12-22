using PB503_classwork_22._12._2024.Task_1;
using PB503_classwork_22._12._2024.task_2;
using PB503_classwork_22._12._2024.Task_3;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Net.WebSockets;
using System.Text.Json;

namespace PB503_classwork_22._12._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //Custom custom1 = new Custom();
            //custom1.Name = "custom1";

            //Custom custom2 = new Custom();
            //custom2.Name = "custom2";

            //Custom custom3 = new Custom();
            //custom3.Name = "custom3";


            //Queue<Custom> customs = new Queue<Custom>();

            //customs.Enqueue(custom1);
            //customs.Enqueue(custom2);
            //customs.Enqueue(custom3);
            //customs.Dequeue();


            //foreach (Custom item in customs)
            //{
            //    Console.WriteLine(item.Name + " "+ item.GetHashCode());
            //}
            #endregion

            #region task2

            #endregion


            #region task3

            Book book1 = new Book()
            {
                Name = "book1",
                Author = "a",

            };

            Book book2 = new Book()
            {
                Name = "book2",
                Author = "a",
            };

            Book book3 = new Book()
            {
                Name = "book3",
                Author = "b",
            };

            Book book4 = new Book()
            {
                Name = "book4",
                Author = "b",
            };

            List<Book> books = new List<Book>();

            string inputMenu;

            string path = "C:\\Users\\ASUS\\Desktop\\";

            do
            {

                Console.WriteLine(@"
1. kitab elave et
2. kitabari goster
3.kitabi adina gore axtar
4.kitab sil
5. melumatlari fayla yaz
6. faydan oxu
");
                inputMenu = Console.ReadLine();

                switch (inputMenu)
                {
                    case "1":

                        books.Add(book1);
                        books.Add(book2);
                        books.Add(book3);
                        books.Add(book4);
                        break;

                    case "2":
                        books.ForEach(x => Console.WriteLine($"{x.Id}, {x.Name}, {x.Author}, {x.PublicationYear}"));
                        break;

                    case "3":
                        Console.WriteLine("enter wanted book name");
                        string name = Console.ReadLine();
                        books.FindAll(x => x.Name == name).ForEach(n => Console.WriteLine(n.Name));

                        break;
                    case "4":

                        Console.WriteLine("enter deleted book id");
                        byte id = Convert.ToByte(Console.ReadLine());
                        books.FindAll(x => x.Id == id).RemoveAll(x => x.Id == id);
                        break;

                    case "5":
                        //if (!File.Exists(path + "task3.txt"))
                        //{
                        //    File.Create(path + "task3.txt");
                        //}


                        var bookJson = JsonSerializer.Serialize(books);
                        File.AppendAllLines(path + "task3.txt", new List<string> { bookJson });

                        using (StreamWriter streamWriter = new StreamWriter(path + "task3.txt"))
                        {
                            streamWriter.Write(bookJson);
                        };


                        break;

                    case "6":
                        using (StreamReader streamreader = new StreamReader(path + "task3.txt"))
                        {
                            books = new List<Book>();
                            books = JsonSerializer.Deserialize<List<Book>>(streamreader.ReadToEnd());
                        };

                        foreach (var book in books)
                        {
                            Console.WriteLine(book.Name);
                        }

                        break;
                    default:
                        Console.WriteLine("enter right menu number");
                        break;

                }

            } while (inputMenu != "0");



            #endregion

        }

    }
}
