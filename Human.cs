using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    abstract class Human: ITransportable{

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

    class Scientist:Human{
        private Equipment equipment;

        public Scientist(Equipment _equipment){
            equipment = _equipment;
        }

        public void Work(double time){

            int iterTime = Convert.ToInt32(time);
            for(int i = 0; i < iterTime/24; i++){
                
                equipment.GatherData();
            }
                
        }
    }

    class Crewman:Human{
            //Empty for now

    }

}
