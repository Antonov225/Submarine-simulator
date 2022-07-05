using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    class Equipment : ITransportable
    {
        protected double volume, weight;
        public double Volume
        {
            get { return volume; }

            set
            {
                volume = value;
                weight = value * 7.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
        public double Weight
        {
            get { return weight; }

            set
            {
                weight = value;
                volume = value / 7.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
        public void GatherData()
        {
            string data = "";
            for (int i = 0; i < 10; i++) data += (char)(new Random()).Next(128);
            Console.WriteLine("Important data gathered: " + data);
        }
        public double GetVolume(){
            return volume;
        }

        public double GetWeight(){
            return weight;
        }

        public void SetVolume(double _volume){
            volume = _volume;
        }

        public void SetWeight(double _weight){
            weight = _weight;
        }
    
    }
}
