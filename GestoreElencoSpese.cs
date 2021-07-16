using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Esercitazione
{
    class GestoreElencoSpese
    {
        public static void HandleNewTextFile(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("un nuovo file è stato appena creato {0}", e.Name);
            try
            {


                //lettura di un file
                using (StreamReader reader = File.OpenText(e.FullPath))
                {
                    Console.WriteLine($"Contenuto del file {e.Name}");
                    string data = reader.ReadLine();
                    

                    while (data != null)
                    {
                         data = reader.ReadLine();
                        string instanceData = reader.ReadLine();
                        string[] values = instanceData.Split(";");

                        DateTime.TryParse(values[0], out DateTime d);
                        Double.TryParse(values[3], out double totamout);

                        new Spesa()
                        {

                            ExpenseDate = d,

                            ItemCategory = values[1],
                            Description = values[2],

                            ToTAmount = totamout
                        };

                       Console.WriteLine(new Spesa().ExpenseDate + "; " + new Spesa().ItemCategory + "; " + new Spesa().Description + "; " + new Spesa().ToTAmount);
                    }



                    Console.WriteLine("Fine del file");
                    Console.WriteLine("\n");

                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                //scrittura su file
                string path = @"C:\Users\sarah.tarantino\source\repos\AC_Week1\Week1.AcademyWeek1\Week1.Esercitazione\SpeseFolder\";
                using (StreamWriter writer = File.CreateText(path + @"\spese.txt"))
                {
                   

                    writer.WriteLine($"Lettura + scrittura su file completata");
                    writer.WriteLine($"{e.ChangeType.ToString()}");
                }

            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

