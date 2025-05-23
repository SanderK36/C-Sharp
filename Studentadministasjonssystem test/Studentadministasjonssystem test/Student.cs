﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministasjonssystem_test
{
    internal class Student
    {
        public string Navn { get; private set; }
        public int Alder { get; private set; }
        public List<Fag> Studieprogram { get; private set; }
        public int StudentID { get; private set; }
        public List<Karakter> Karakterer { get; private set; }


        public Student(string navn, int alder, List<Fag> studieprogram, int studentID)
        {
            Navn = navn;
            Alder = alder;
            Studieprogram = studieprogram;
            StudentID = studentID;
            
            makeGrades();

        }
        public void SkrivUtInfo()
        {
            Console.WriteLine($"Navn: {Navn}");
            Console.WriteLine($"Alder: {Alder}");
            Console.WriteLine($"StudentID: {StudentID}");
            StudentProgram();
        }

        public void StudentProgram()
        {
            foreach (var Fag in Studieprogram)
            {
                Console.WriteLine(Fag.AntallStudiepoeng);
                Console.WriteLine(Fag.Fagkode);
                Console.WriteLine(Fag.Fagnavn);
            }
        }

        public void Karak()
        {
            foreach (var Karakter in Karakterer)
            {
                Console.WriteLine(Karakter.KarakterVerdi);
            }
        }

        public void GetAverageGrade()
        {
            int totalSum = 0;

            foreach (var grade in Karakterer)
            {
                totalSum += grade.KarakterVerdi;
            }
            Console.WriteLine(totalSum / Karakterer.Count);
        }

        public void makeGrades()
        {
            Karakterer = new List<Karakter>()
            {
                new Karakter(StudentID, "TEST3", 4),
                new Karakter(StudentID, "TEST2", 3),
                new Karakter(StudentID, "TEST1", 5)
            };
        }

        public void showTotalPoints()
        {
            int points = 0;

            foreach (var fag in Studieprogram)
            {
                points += fag.AntallStudiepoeng;
            }
            Console.WriteLine(points);
        }
    }
}
