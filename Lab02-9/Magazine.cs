using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblWorm
{
    class Magazine : Item, IPubs
    {
        private String title;  // название
        private String volume;    // том
        private int number;        // номер    
        private int year;      // дата выпуска

        public bool IfSubs { get; set; } // подписка на журнал

        public Magazine(String title, String volume, int number, int year, int invNumber, bool taken)
            : base(invNumber, taken)
        {
            this.title = title;
            this.volume = volume;
            this.number = number;
            this.year = year;
        }


       public override void Return()    // операция "вернуть"
       {
           taken = true;
       }

        // реализация интерфейса

      

      public void Subs()
      {
          // действия при оформлении подписки на журнал
      }


       public override string ToString()
       {
           if (IfSubs)
           return "-----Журнал-----\nНазвание: " + title + "\nТом: " + volume +
           "\nНомер: " + number + "\nГод выпуска: " + year + "\n" + base.ToString() + "Подписка оформлена\n";
           else
               return "-----Журнал-----\nНазвание: " + title + "\nТом: " + volume +
           "\nНомер: " + number + "\nГод выпуска: " + year + "\n" + base.ToString() + "Подписка не оформлена\n";
       }
    }
}
