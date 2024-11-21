using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Student
    {
        string _navn;
        int _alder;
        string _studieProgram;
        int _studentID;

        public Student(string navn, int alder, string studieProgram, int studentID)
        {
            _navn = navn;
            _alder = alder;
            _studieProgram = studieProgram;
            _studentID = studentID;   
        }

        void SkrivUtInfo()
        {
            Console.WriteLine($"Student: {_navn}\nAlder: {_alder}\nProgram: {_studieProgram}\nID: {_studentID}");
        }
    }
}
