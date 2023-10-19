using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDolgozat
{
    internal class Alarm
    {
        public int alarmHour {  get; set; }
        public int alarmMinute { get; set; }
        public bool isAlarmOn { get; set; }

        //Konstruktor, amely inicializálja az ébresztés osztályt a megadott ébresztési idővel.
        public Alarm(int hour, int minute)
        {
            alarmHour = hour;
            alarmMinute = minute;
        }

        //Beállítja az ébresztés időpontját a megadott értékekre.
        public void SetAlarm(int hour, int minute)
        {
            this.alarmHour = hour;
            this.alarmMinute = minute;
        }

        //Engedélyezi az ébresztést.
        public void TurnOnAlarm()
        {
            if (isAlarmOn == false)
            {
                isAlarmOn = true;
            }
        }
        //Letiltja az ébresztést.

        public void TurnOffAlarm()
        {
            if(isAlarmOn == false)
            {
                isAlarmOn = true;
            }
        }
        //Ellenőrzi, hogy az ébresztési időpont elérkezett-e, és visszaadja a találat eredményét.
        public bool IsAlarmTime(int hour, int minute)
        {
            if (alarmHour == hour && alarmMinute == minute)
            {
                
                return true;
                
            }
            else
            {
                
                return false;
                
            }
        }
    }
}
