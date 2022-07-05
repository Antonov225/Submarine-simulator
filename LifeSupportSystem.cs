using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    class LifeSupportSystem{
        private List<OxygenBottle> oxygenBottles = new List<OxygenBottle>();
        private FoodContainer foodContainer;
        private Waste waste;
        private List<Human> crew = new List<Human>();

        public LifeSupportSystem(List<OxygenBottle> bottles, FoodContainer container, Waste _waste, List<Human> _crew){
            oxygenBottles = bottles;
            foodContainer = container;
            waste = _waste;
            crew = _crew;
        }

        public bool CheckSuppliesBeforeTravel(double travelTime){
            if((oxygenBottles.Count() > travelTime * 0.0005) && (foodContainer.Weight > travelTime * 0.0005)){
                return true;
            }
            else
                return false;
        }

        public void Run(double travelTime){

            foreach (var bottle in oxygenBottles) {bottle.Weight -= 10;}
            foodContainer.Weight -= travelTime * 40;
            waste.Weight +=  travelTime * 20;
        }

    }

}