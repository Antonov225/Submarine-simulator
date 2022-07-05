using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    class Engine{
        private FuelTank tank;
        private Waste waste;
        public Engine(FuelTank _tank, Waste _waste){
            tank = _tank;
            waste = _waste;
        }

        public double GetVelocity(double submarineWeight){
            return (submarineWeight + tank.Weight) * 0.00005;
        }

        public bool CheckFuelBeforeTravel(double travelTime){
            if (travelTime*1.8 < tank.Weight){
                return true;
            }
            else
                return false;
        }

        public void Travel(double travelTime){
            waste.Weight = waste.Weight + 0.8 * travelTime;
            tank.Weight = tank.Weight - 0.6 * travelTime;
        }

    }

}