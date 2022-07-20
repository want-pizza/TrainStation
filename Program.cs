using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainStation
{
    
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>

        [STAThread]
        static void Main()
        {
            SetTrains();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Form());
        }

        public static void SetTrains()
        {
            List<string> temp = new List<string>();
            temp.Add("9:00");           
            temp.Add("15:00");
            temp.Add("21:00");
            Trains.AddNewTrain(new Train(92, "Київ", "Рівно, Житомир", new List<string>(temp), 90, 320));
            temp.Clear();
            temp.Add("6:10");
            temp.Add("10:20");
            temp.Add("14:30");
            temp.Add("18:40");
            temp.Add("22:50");
            Trains.AddNewTrain(new Train(12, "Рівне", "-", new List<string>(temp), 80, 80));
            temp.Clear();
            temp.Add("5:45");
            temp.Add("21:15");
            Trains.AddNewTrain(new Train(12, "Сімферополь", "Вінниця, Умань, Миколаїв, Херсон", new List<string>(temp), 220, 360));
            temp.Clear();
        }
    }
}
