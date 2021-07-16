using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Esercitazione
{
    class Spesa : SpesaGenerale
    {
        public DateTime ExpenseDate { get; set; }
        public string ItemCategory { get; set; }
        public string Description { get; set; }
        public Double ToTAmount { get; set; }

        public Spesa(DateTime expenseDate, string itemCategory, string description, double toTAmount)
        {
            ExpenseDate = expenseDate;
            ItemCategory = itemCategory;
            Description = description;
            ToTAmount = toTAmount;
        }

        public Spesa()
        {
        }

        /*
            Formato file
            data: 2021-07-13
            
            Data;Categoria;Descrizione;Importo

           */
        public override  void SaveToFile(string fileName)
        {
            try
            {
                string path = @"C:\Users\sarah.tarantino\source\repos\AC_Week1\Week1.AcademyWeek1\Week1.Esercitazione\SpeseFolder\";
                using (StreamWriter writer = File.CreateText(path + fileName))
                {
                    writer.WriteLine("data:" + DateTime.Today.ToShortDateString());
                    writer.WriteLine("values:" + ExpenseDate + "; " + ItemCategory + "; " + Description + "; " + ToTAmount);


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




       /*public override void LoadFromFile(string fileName)
        {


            try
            {
                string path = @"..\Week1\Esercitazione\SpeseFolder";

                using (StreamReader reader = File.OpenText(path + fileName))
                {

                    string data = reader.ReadLine();
                    string instanceData = reader.ReadLine();
                    string[] values = instanceData.Split(";");

                    // string dataExpense = values[1].Split(";");

                    DateTime.TryParse(values[0], out DateTime d);

                    ExpenseDate = d;

                    ItemCategory = values[1];
                    Description = values[3];
                    Double.TryParse(values[4], out double totamout);
                    ToTAmount = totamout;
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } */
        }
 
}
