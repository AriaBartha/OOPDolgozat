using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDolgozat
{
    internal class Clock
    {
        public int hour {  get; set; }
        public int minute { get; set; }
        public int second { get; set; }
        public string timeZone { get; set; }
        public bool is24HourFormat {  get; set; }

        //Konstruktor, amely inicializálja az óra osztályt a megadott értékekkel.
        public Clock(int hour, int minute, int second, string timeZone, bool is24HourFormat)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
            this.timeZone = timeZone;
            this.is24HourFormat = is24HourFormat;
        }
        //Beállítja az óra, perc és másodperc értékeket a megadott értékekre.
        public void SetTime(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        //Kiírja az aktuális időt a konzolra a kiválasztott időformátumban és az időzónával.
        public void DisplayTime()
        {
            if (is24HourFormat == true)
            {
                Console.WriteLine($"The current time is: {hour}:{minute}:{second}:{timeZone}");
            }
            else
            {
                Console.WriteLine($"The current time is: {hour}:{minute}:{second}:{timeZone}");
            }
        }
        //Beállítja az időzónát a megadott értékre.
        public void SetTimeZone(string timeZone)
        {
            this.timeZone = timeZone;
        }

        //Vált az időformátum között (24 órás és 12 órás között).
        public void ToggleTimeFormat()
        {
            if (is24HourFormat == true && hour > 12)
            {
                this.hour = hour - 12;
                Console.WriteLine($"Current time: {hour}:{minute}:{second} p.m.");
            }
            else if (is24HourFormat == true && hour < 12)
            {
                Console.WriteLine($"The time is:{hour}:{minute}:{second} a.m.");
            }
            else if (is24HourFormat == true && hour == 12)
            {
                Console.WriteLine($"The time is {hour}:{minute}:{second}");
            }
            else if(is24HourFormat == false)
            {
                Console.WriteLine($"The time is {hour}:{minute}:{second}");
            }
            

            
        }

    }
}
