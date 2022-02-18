using System;
using System.Collections.Generic;
using System.Text;

namespace Eläinvakuutukset
{
    class InsuranceManager
    {
        //public void AddInsurance(string v1, string v2, bool v3)
        //{
        //    return $"{this.ToString()}";
        //}
        public List<Insurance> allInsurances = new List<Insurance>();

        public InsuranceManager()
        {
            
        }


        public void AddInsurance(string animal, string name, bool isNeutered) // metodilla 3 parametria
        {
            Console.WriteLine($"ANIMAL: {animal}, NAME: {name}, NEUTERED: {isNeutered}, FEE: {GetFee(animal, isNeutered)}");
            allInsurances.Add(new Insurance(animal, name, isNeutered, GetFee(animal, isNeutered)));
        }

        public double GetFee(string animal, bool isNeutered) // metodilla 2 parametria
        {
            if (animal == "koira" && isNeutered == true)
            {
                return 50;
            }
            else if (animal == "koira" && isNeutered == false)
            {
                return 80;
            }
            else if (animal == "kissa" && isNeutered == true)
            {
                return 40;
            }
            else if (animal == "kissa" && isNeutered == false)
            {
                return 60;
            }
            else if (animal == "lintu")
            {
                return 0;
            }
            else if (animal == "matelija")
            {
                return 0;
            }
            return 0;
        }

        public void PrintInsurances()
        {
            Console.WriteLine($"\nvakuutuksia yhteensä " + allInsurances.Count);
            Console.WriteLine("\nvakuutukset:\n ");
            foreach (Insurance insurance in allInsurances)
            {
                
                Console.WriteLine(insurance.ToString());
                Console.WriteLine();
            }
        }

        public void FindInsurances(string species, bool isNeutered) // metodilla 2 parametria
        {
            Console.WriteLine("löytyi:\n");
            foreach (Insurance insurance in allInsurances)
            {
                if (insurance.species == species && insurance.neutered == isNeutered)
                {
                    //Console.WriteLine(species);
                    //Console.WriteLine(insurance.species);
                    Console.WriteLine(species + ": " + insurance.name + ", vakuutusmaksu " + insurance.fee + " €\n");
                 
                }
            }
        }
    }
}
