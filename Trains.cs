using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation
{

    class Trains
    {
        static List<Train> trains = new List<Train>();
        static public void AddNewTrain(Train train) { trains.Add(train); }
        static public List<Train> GetTrains
        {
            get
            {
                return trains;
            }
        }
        static public List<Train> Sorting_by_Town(string _town)
        {
            List<Train> temp = new List<Train>();
            foreach (Train t in trains)
            {
                if (t.Town == _town)
                {
                    temp.Add(t);
                }
            }
            return temp;
        }
        //static public List<Train> Sorting_by_Town_and_Date(string _town, string _time)
        //{
        //    List<Train> temp = new List<Train>();
        //    List<Train> _trains = Sorting_by_Town(_town);
        //    foreach (Train t in _trains)
        //    {
        //        foreach (string i in t.Time)
        //        {
        //            if (_time == i)
        //            {
        //                temp.Add(t);
        //            }
        //        }
        //    }
        //    return temp;
        //}
    }
    class Train
    {
        int number;
        string town;
        DateTime date;
        string stops;
        List<string> time;
        int free_places;
        int price;
        

        public Train(int _number, string _town, string _stops, List<string> _time,int _free_places, int _price)
        {
            Random r = new Random();
            number = _number;
            town = _town;
            stops = _stops;
            time = _time;
            free_places = _free_places;
            price = _price;          
        }

        public string Town
        {
            get
            {
                return town;
            }
        }
        public DateTime Date
        {
            get
            {
                return date;
            }
        }
        public List<string> Time
        {
            get
            {
                return time;
            }
        }
        public float Price
        {
            get
            {
                return price;
            }
        }
        public int Number
        {
            get
            {
                return number;
            }
        }
        public int Free_Places
        {
            set
            {
                free_places = value;
            }
            get
            {
                return free_places;
            }
        }
    }
}
