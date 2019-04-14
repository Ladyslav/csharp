using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._04
{
    public class Voler
    {
        private Animals _animal;
        private Roslunu _plant;

        public void PlaxeAnimal(Animals animal)
        {
            _animal = animal;
        }
        public void PlacePlant(Roslunu plant)
        {
            _plant = plant;
        }

        public void GetStatus()
        {
            var result = "";
            if (_animal != null && _plant != null)
                result += "Animal and plant Present";
       

        }
    }
}
