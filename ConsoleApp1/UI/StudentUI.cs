﻿using ConsoleApp1.Data;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.UI
{
    class StudentUI
    {
        public static void PrikaziStudente()
        {
            List<Student> students = VirtualDB.Studenti.GetAll();

            foreach (Student item in students)
            {
                Console.WriteLine("Id: " + item.Id);
                Console.WriteLine("Ime: " + item.Ime);
                Console.WriteLine("Prezime: " + item.Prezime);
            }
        }

        public static void DodajStudenta()
        {
            Student s = new Student();

            Console.WriteLine("Unesite ime: ");
            s.Ime = Console.ReadLine();

            Console.WriteLine("Unesite prezime: ");
            s.Prezime = Console.ReadLine();

            VirtualDB.Studenti.Insert(s);

            Console.WriteLine("----------------------------");
        }
    }
}
