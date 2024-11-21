using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Karakter
    {
        Student _student;
        Fag _fag;
        string _karakterVerdi; //mer universal, siden du kan muligens få A- eller 4+

        void SkrivUtInfo()
        {
            Console.WriteLine($"Student: {_student}\nFag: {_fag}\nKarakter: {_karakterVerdi}");
        }

    }
}
