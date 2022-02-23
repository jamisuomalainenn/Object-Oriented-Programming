using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FileExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string filePath = @"C:\Users\jamis\Source\Repos\OlioOhjelmointi\FileExercise\TextFile1.txt";

            FileManager fm = new FileManager();
            try
            {
                string text = fm.ReadWords();
                Console.WriteLine(text);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            WriteFile();
            ReadFile();
            WriteJsonFile();
            ReadJsonFile();
            
            static void WriteFile()
            {
                Console.WriteLine("\nWriting to file data.txt");

                const string path = @"C:\Users\jamis\Source\Repos\OlioOhjelmointi\FileExercise\data.txt";

                if (File.Exists(path))
                {
                    //File.WriteAllLines(string path, string[] contents, System.Text.Encoding encoding);
                    // File.AppendAllText(string path, string contents);
                    
                    {
                        // Create a file to write to.
                        string[] createText = { "Hello", "And", "Welcome" };
                        File.WriteAllLines(path, createText);
                    }

                    // This text is always added, making the file longer over time
                    // if it is not deleted.
                    string appendText = "This is extra text" + Environment.NewLine;
                    File.AppendAllText(path, appendText);
                }

                // File.Exists(string path);
                
            }

            static void ReadFile()
            {
                Console.WriteLine("\nReading file data.txt");

                const string path = @"C:\Users\jamis\Source\Repos\OlioOhjelmointi\FileExercise\data.txt";

                if (File.Exists(path))
                {
                    //File.ReadAllLines(string path);
                    string[] readText = File.ReadAllLines(path);
                    foreach (string s in readText)
                    {
                        Console.WriteLine(s);
                    }
                }

            }

            static void WriteJsonFile()
            {
                Console.WriteLine("\nWriting Json data to books.txt file");

                const string jsonFile = @"C:\Users\jamis\Source\Repos\OlioOhjelmointi\FileExercise\books.txt";

                List<Book> bookList = new List<Book>();
                bookList.Add(new Book()
                {
                    title = "Fingerpori",
                    author = "Pertti Jarla",
                    id = "978123123",
                    price = 17.95

                }
                );
                bookList.Add(new Book()
                {
                    title = "Witcher",
                    author = "Rosa Nurminen",
                    id = "9781234103",
                    price = 25.90

                }
               );
                bookList.Add(new Book()
                {
                    title = "Aapinen",
                    author = "Aaltonen Antti",
                    id = "9781",
                    price = 20.00

                }
               );


                //string json = JsonSerializer.Serialize(bookList);
                File.WriteAllText(@"C:\Users\jamis\Source\Repos\OlioOhjelmointi\FileExercise\books.txt", JsonConvert.SerializeObject(bookList));

                // File.WriteAllText(string path, string contents);
                // JsonConvert.SerializeObject(Object value);

                // Serialize JSON to a file
                // https://www.newtonsoft.com/json/help/html/SerializeWithJsonSerializerToFile.htm

            }



            static void ReadJsonFile() 
            {
                Console.WriteLine("\nReading Json data from books.txt file");

                List<Book> bookList = JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(@"C:\Users\jamis\Source\Repos\OlioOhjelmointi\FileExercise\books.txt", System.Text.Encoding.UTF8));
                Console.WriteLine(bookList);

                File.WriteAllText(@"C:\Users\jamis\Source\Repos\OlioOhjelmointi\FileExercise\books.txt", JsonConvert.SerializeObject(bookList));

                //for (int i = 0; i < bookList.Count; i++)
                //{
                //    Console.WriteLine(bookList[i]);
                //}
                var pathh = @"C:\Users\jamis\Source\Repos\OlioOhjelmointi\FileExercise\books.txt";
                string jjsonFile = File.ReadAllText(pathh);
                //Book b = JsonConvert.DeserializeObject<Book>(jjsonFile);
               //foreach (var item in b.title)
               // {
               //     Console.WriteLine($"{ item }");
               // }



                //en osannut näitä jsoneja tehdä...




                String path = @"C:\Users\jamis\Source\Repos\OlioOhjelmointi\FileExercise\books.txt";

                String lines;
                lines = File.ReadAllText(path);
                Console.WriteLine(lines);

                Console.ReadKey();


                const string jsonFile = @"C:\Users\jamis\Source\Repos\OlioOhjelmointi\FileExercise\books.txt";

                // File.ReadAllText(string path, E



               
            }

            }
        }
}
