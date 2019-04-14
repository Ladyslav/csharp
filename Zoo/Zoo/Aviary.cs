﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Aviary
    {
        private Animal _animal;
        private Plant _plant;

        public bool IsClean { get; set; }
        public void PlaxeAnimal(Animal animal)
        {
            _animal = animal;
        }

        public void PlacePlant(Plant plant)
        {
            _plant = plant;
        }

        public string GetStatus()
        {
            if (_animal != null)
                return "Animal is inside";

            if (_plant != null)
                return "Plany is here";

            return "Empty";
        }
        }
}
