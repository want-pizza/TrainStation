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
            Random random = new Random();
            List<string> temp = new List<string>();
            List<int> i = new List<int>();
            temp.Add("9:00");
            temp.Add("15:00");
            temp.Add("21:00");

            i.Add(random.Next(0, 120));
            i.Add(random.Next(0, 120));
            i.Add(random.Next(0, 120));
            Trains.AddNewTrain(new Train(92, "Київ", "Рівно, Житомир", new List<string>(temp), new List<int>(i), 320));

            temp.Clear();
            i.Clear();
            temp.Add("6:10");
            temp.Add("10:20");
            temp.Add("14:30");
            temp.Add("18:40");
            temp.Add("22:50");

            i.Add(random.Next(0, 120));
            i.Add(random.Next(0, 120));
            i.Add(random.Next(0, 120));
            i.Add(random.Next(0, 120));
            i.Add(random.Next(0, 120));
            Trains.AddNewTrain(new Train(12, "Рівне", "-", new List<string>(temp), new List<int>(i), 80));
            temp.Clear();
            i.Clear();
            temp.Add("5:45");
            temp.Add("21:15");
            i.Add(random.Next(0, 120));
            i.Add(random.Next(0, 120));
            Trains.AddNewTrain(new Train(12, "Сімферополь", "Вінниця, Умань, Миколаїв, Херсон", new List<string>(temp), new List<int>(i), 360));
            temp.Clear();
            i.Clear();
        }
    }
}
