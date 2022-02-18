using System;
using System.Collections.Generic;
using System.Text;

namespace Eläinvakuutukset
{
    class Insurance
    {
        private String species;
        private String name;
        private bool neutered;
        private double fee;
        public Insurance(String animal, String name, bool isNeutered, double payment)
        {
            this.species = animal;
            this.name = name;
            this.neutered = isNeutered;
            this.fee = payment;
        }

        //tässä tehdään get - set metodit, jotta kentät voi pitää private-muodossa
        //get - set metodeja ei tarvitse jos kentät muutaa publiciksi
        public string _species { get => species; set => species = value; }
        public string _name { get => name; set => name = value; }
        public bool _neutered { get => neutered; set => neutered = value; }
        public double _fee { get => fee; set => fee = value; }

        public String GetNeuteredInfo()
        {
            if (_neutered)
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
