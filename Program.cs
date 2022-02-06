using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methoden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Methoden sind Code-Blöcke die über ihren Namen aufgerufen werden können. 
            //Dadurch muss man nicht den Code immer und immer wieder neu schreiben, erleichtert die Übersicht
            //Methoden können auch Werte als Ergebnis zurückgeben, Methoden erfüllen nur eine einzige Aufgabe
            //Klasse/Methode/Parameter

            SayHello("Amy", 38);
            SayHello("David", 31);

            int zahl = Addition(10, 5);
            Console.WriteLine(zahl);

            Console.ReadKey();

        }
        static void SayHello(string name, int age) //Methode ohne Rückgabewert
        {
            Console.WriteLine("Hey {0}, bist {1} Jahre alt! ", name, age);
        }

        static int Addition(int nr1, int nr2) //Methode mit Rückgabewert (Ein Datentyp muss angegeben werden)
        {
            int ergebnis = nr1 + nr2;
            return ergebnis; //return beendet eine Methode, folgender Code wird nicht ausgeführt
        }
    }
}
