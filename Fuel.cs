using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    abstract class Fuel : ITransportable{
        protected double volume, weight;
        protected double density; 
        public string Material {set; get;}

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

        public string GetMaterial(){
            return Material;
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

    class FuelNuclear:Fuel{
        public FuelNuclear(){
            Material = "Nuclear";
            density = 50;
        }

    }

    class FuelDiesel:Fuel{
        public FuelDiesel(){
            Material = "Diesel";
            density = 15;
        }

    }

}
