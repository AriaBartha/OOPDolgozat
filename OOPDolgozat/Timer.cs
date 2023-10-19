using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDolgozat
{
    internal class Timer
    {
        //A hátralévő időt másodpercekben tárolja.

        public int remainingSeconds {  get; set; }

        //Konstruktor, amely inicializálja az időzítőt a megadott másodpercekkel.
        public Timer(int seconds)
        {
            remainingSeconds = seconds;
        }

        //Beállítja az időzítőt a megadott időre másodpercekben.

        public void SetTime(int seconds)
        {
            remainingSeconds = seconds;
        }
        //Elindítja az időzítőt, visszaszámlálva a beállított időig, és közben kiírja az eltelt időt a konzolra.
        public void StartTimer()
        {
            for(int i = remainingSeconds; i >= 0; i--)
            {
                Console.WriteLine(i);

            }
        }
    }
}
