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
    }
    class Train
    {
        int number;
        string town;
        DateTime date;
        string stops;
        List<string> time;
        List<int> free_places;
        int price;
        

        public Train(int _number, string _town, string _stops, List<string> _time,List<int> _free_places, int _price)
        {
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

            public string Stops
        {
            get
            {
                return stops;
            }
        }
        public DateTime Date
        {
            set
            {
                date = value;
            }
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
        public List<int> Free_Places
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
