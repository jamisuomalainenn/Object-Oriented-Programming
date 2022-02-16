using System;

namespace Eläinvakuutukset
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            InsuranceManager im = new InsuranceManager();
            im.AddInsurance("koira", "Rolle", false);
            im.AddInsurance("koira", "Tessu", true);
            im.AddInsurance("kissa", "Monni", true);
            im.AddInsurance("koira", "Pluto", false);
            im.AddInsurance("lintu", "Tipi", false);
            im.PrintInsurances();
            Console.WriteLine("---\n");
            im.FindInsurances("koira", false);

        }
    }
}
