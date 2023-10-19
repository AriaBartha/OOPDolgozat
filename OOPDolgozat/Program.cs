using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDolgozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Hozz létre egy Clock példányt a következő paraméterekkel:
                                        Aktuális óra: 12
                                        Aktuális perc: 30
                                        Aktuális másodperc: 45
                                        Időzóna: "UTC+2"
                                        Időformátum: 24 órás*/

            Clock myClock = new Clock(12, 30, 45, "UTC+2", true);

            /*Hozz létre egy List<Alarm> listát az ébresztések tárolásához.Adj hozzá legalább két ébresztést a listához a következő paraméterekkel:
                                        Ébresztés 1: óra: 6, perc: 0
                                        Ébresztés 2: óra: 8, perc: 0*/
            List<Alarm> alarmList = new List<Alarm>();
            Alarm alarm1 = new Alarm(6, 0);
            alarmList.Add(alarm1);
            Alarm alarm2 = new Alarm(8,0);
            alarmList.Add(alarm2);
            

            /*Hozz létre egy Timer példányt a következő paraméterekkel:
                                        Időzítő időtartama: 10 másodperc*/

            Timer myTimer = new Timer(10);

            //Kiírja az aktuális időt a konzolra a myClock.DisplayTime() metódussal.
            myClock.DisplayTime();
            Console.WriteLine();

            /*Ellenőrizze az ébresztéseket a következőképpen:
                            Menjen végig a alarms listán lévő ébresztéseken.
                            Használja a IsAlarmTime metódust, hogy ellenőrizze, hogy elérkezett-e az ébresztési idő a jelenlegi óra és perc alapján.
                            Ha egy ébresztés ideje elérkezett, írja ki a konzolra "Az ébresztő megszólalt!" üzenettel.*/
            foreach (var alarm in alarmList)
            {
                if(alarm.IsAlarmTime(myClock.hour,myClock.minute) == true)
                {
                    Console.WriteLine("Az ébresztő megszólalt!");
                }
            }
            


            //Indítsa el az időzítőt a myTimer.StartTimer() metódussal.Az időzítő visszaszámlál a beállított időig, és közben kiírja az eltelt időt a konzolra.
            Console.WriteLine("Az időzítő visszaszámol:");
            myTimer.StartTimer();
            
            //További tesztelések:
            Console.WriteLine();
            Console.WriteLine("Az óra további tesztelése:");
            Console.WriteLine("Időzóna átállítása UTC+4-re");
            myClock.SetTimeZone("UTC+4");
            myClock.DisplayTime();
            Console.WriteLine();
            Console.WriteLine("Váltás 24-ről 12 órás kiírásra:");
            myClock.ToggleTimeFormat();
            Console.WriteLine();
            Console.WriteLine("Idő átállítása és az átállítás működésének ellenőrzése:");
            myClock.SetTime(18, 30, 45);          
            myClock.DisplayTime();
            Console.WriteLine("Váltás 24-ről 12 órás kiírásra:");
            myClock.ToggleTimeFormat();
            Console.WriteLine();
            Console.WriteLine("Beállított ébresztések: ");
            foreach (var alarm in alarmList)
            {
                Console.WriteLine($"{alarm.alarmHour}:{alarm.alarmMinute}");
            }
            Console.WriteLine();
            Console.WriteLine("Elérkezett az ébresztés ideje?");
            myClock.SetTime(6, 0, 0);
            myClock.DisplayTime();
            alarm1.TurnOnAlarm();
            bool result = alarm1.IsAlarmTime(myClock.hour, myClock.minute);
            if (result == true)
            {
                Console.WriteLine("Az ébresztő megszólalt!");
            }
            

            Console.ReadLine();
        }
    }
}
