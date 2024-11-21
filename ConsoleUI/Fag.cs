using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Fag
    {
        string _fagKode; //velger string siden f-kode kan være "RF320" og/eller 000341
        string _fagNavn;
        int _studiePoeng;

        public Fag(string fagKode, string fagNavn, int studiePoeng)
        {
            _fagKode = fagKode;
            _fagNavn = fagNavn;
            _studiePoeng = studiePoeng;
        }

        void SkrivUtInfo()
        {
            Console.WriteLine($"Fagkode: {_fagKode}\nFag: {_fagNavn}\nAntall poeng: {_studiePoeng}");
        }

    }
}
