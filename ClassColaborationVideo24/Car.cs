using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassColaborationVideo24
{
    public class Car
    {
        //Instance fields
        private Engine _theEngine;
        private NavSys _theNavsys;
        private Wheel _theWheel;

        //Constructors

        public Car(string modelName, double co2FromProduction, Wheel theWheel)
        {
            ModelName = modelName;
            Co2FromProduction = co2FromProduction;
            _theEngine = new Engine(120, "Gasoline", 2000);
            _theNavsys = new NavSys("Garmin", "Touch", "Covers EU", 4000);
            _theWheel = theWheel;
        }

        // Properties

        public string ModelName { get; set; }
        public double Co2FromProduction { get; set; }

        public Engine TheEngine
        {
            get { return _theEngine; }

        }

        public NavSys TheNaviSys
        {
            get { return _theNavsys; }
        }

        public Wheel TheWheel
        {
            get { return _theWheel; }
        }


        //Methods

        public void Start()
        {
            Console.WriteLine("Bilen startes");
            _theEngine.Start();
            _theNavsys.Start();
        }

        public void ChangeWheel(Wheel aWheel)
        {
            _theWheel = aWheel;
        }

        public double CalCo2Emission()
        {
            double totalCo2 = this.Co2FromProduction + _theEngine.Co2FromProduction + _theNavsys.Co2FromProduction + _theWheel.Co2;
            return totalCo2;
        }

        public override string ToString()
        {
            return $"Modelname {ModelName}\n\tEngine {_theEngine.ToString()}\n\tNavigation System {_theNavsys.ToString()} \n\tWheel {_theWheel.ToString()} ";
        }
    }
        
}
