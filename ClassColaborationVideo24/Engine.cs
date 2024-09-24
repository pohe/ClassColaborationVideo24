﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassColaborationVideo24
{
    public class Engine
    {
        private int _hp;

        public int HP
        {
            get { return _hp; }
            set { _hp = value; }
        }

        public string Fuel
        {
            get;
            set;
        }

        public double Co2FromProduction
        {
            get;
            set;
        }

        public Engine(int hp, string fuel, double co2FromProduction)
        {
            _hp = hp;
            Fuel = fuel;
            Co2FromProduction = co2FromProduction;
        }


        public void Start()
        {
            Console.WriteLine("The engine has started");
        }

        public override string ToString()
        {
            return $"Your engine has {_hp} horse points, uses the fuel type {Fuel}, and emits {Co2FromProduction} CO2";
        }
    }
}
