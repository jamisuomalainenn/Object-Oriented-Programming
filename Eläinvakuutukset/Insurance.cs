using System;
using System.Collections.Generic;
using System.Text;

namespace Eläinvakuutukset
{
    class Insurance
    {
        public String species;
        public String name;
        public bool neutered;
        public double fee;
        public Insurance(String animal, String name, bool isNeutered, double payment)
        {
            this.species = animal;
            this.name = name;
            this.neutered = isNeutered;
            this.fee = payment;
        }
        public String GetNeuteredInfo()
        {
            if (neutered)
            {
                return "leikattu";
            }
            else
            {
                return "leikkaamaton";
            }
        }
        public override String ToString()
        {
            return this.species + ": " + this.name + ", " + this.GetNeuteredInfo();
        }
    }
}
