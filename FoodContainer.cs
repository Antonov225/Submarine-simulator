using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    class FoodContainer : IVisitPort, ITransportable{

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
        
        public double MaxCapacity {set; get;}
        public FoodContainer(double capacity){
            MaxCapacity = capacity;
        }

        public double GetMaxCapacity(){
            return MaxCapacity;
        }

        public double VisitPort(){
            double cost = 0;
            cost = MaxCapacity - volume;
            volume = MaxCapacity;
            return cost * 1265;
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