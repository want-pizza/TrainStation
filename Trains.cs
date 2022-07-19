using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation
{
    class Trains
    {
        List<Train> trains = new List<Train>();
        public List<Train> Sorting_by_Town(string _town)
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
        public List<Train> Sorting_by_Town_and_Date(string _town, DateTime _date)
        {
            List<Train> temp = new List<Train>();
            List<Train> _trains = Sorting_by_Town(_town);
            foreach (Train t in _trains)
            {
                if (t.Date == _date)
                {
                    temp.Add(t);
                }
            }
            return temp;
        }
        public List<Train> Sorting_by_Town_and_DateTime(string _town, DateTime _date, DateTime _time)
        {
            List<Train> temp = new List<Train>();
            List<Train> _trains = Sorting_by_Town_and_Date(_town, _date);
            foreach (Train t in _trains)
            {
                if (t.Time == _time)
                {
                    temp.Add(t);
                }
            }
            return temp;
        }
    }
    class Train
    {
        int number;
        string town;
        DateTime date;
        DateTime time;
        float price;
        int free_places;

        public Train(int _number, string _town, DateTime _date, DateTime _time, float _price)
        {
            Random r = new Random();
            number = _number;
            town = _town;
            date = _date;
            time = _time;
            price = _price;
            free_places = r.Next(1000) + 1;
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
        public DateTime Time
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
