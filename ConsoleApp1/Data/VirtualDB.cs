using ConsoleApp1.Helper;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    class VirtualDB
    {
        public static FTable<Student> Studenti { get; set; }
        public static FTable<Fakultet> Fakulteti { get; set; }
        public static FTable<Smjer> Smjerovi { get; set; }
        public static FTable<AkademskaGodina> AkademskeGodine { get; set; }
        public static FTable<UpisGodine> UpisiGodine { get; set; }

        private VirtualDB() 
        {
            // this ensures that objects of this class could not be created (because we want to use static properties)
        }

        static VirtualDB()      // static constructor
        {
            Studenti = new FTable<Student>();
            Fakulteti = new FTable<Fakultet>();
            Smjerovi = new FTable<Smjer>();
            AkademskeGodine = new FTable<AkademskaGodina>();
            UpisiGodine = new FTable<UpisGodine>();
        }
    }
}
