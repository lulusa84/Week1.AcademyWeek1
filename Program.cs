using System;
using System.IO;

namespace Week1.Esercitazione
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___ Watcher Spese____");
            FileSystemWatcher fsw = new FileSystemWatcher();

            //percorso da tenere monitorato
            fsw.Path = @"C:\Users\sarah.tarantino\source\repos\AC_Week1\Week1.AcademyWeek1\Week1.Esercitazione\SpeseFolder\";

            //definisco il filtro  di controllo sui file .txt
            fsw.Filter = "*txt";

            fsw.NotifyFilter = NotifyFilters.LastWrite |

                 NotifyFilters.LastAccess | NotifyFilters.FileName |

                 NotifyFilters.DirectoryName;

            //Abilito notifiche
            fsw.EnableRaisingEvents = true;

            //iscrizione ad evento
            fsw.Created += GestoreElencoSpese.HandleNewTextFile;

            while (Console.Read() != 'q') ;
        }
        
        }
    }

