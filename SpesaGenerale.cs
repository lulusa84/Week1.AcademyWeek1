using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Esercitazione
{
    public abstract class SpesaGenerale : IFileSerializable
    {
        public string ItemCategory { get; set; }
        public Double ToTAmount { get; set; }

        //public abstract void LoadFromFile(string fileName);
        public abstract void SaveToFile(string FileName);
    }
}
