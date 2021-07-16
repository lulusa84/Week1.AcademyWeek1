using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Esercitazione
{
    interface IFileSerializable
    {
        // public string Path {get, set} ;
        public void SaveToFile(string FileName);
        //public void LoadFromFile(string fileName);
        // public Task  SaveToFileAsync(string FileName);
        // public Task  LoadFromFileSync(string fileName);
    }
}
