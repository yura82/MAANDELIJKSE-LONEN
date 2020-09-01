using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAANDELIJKSE_LONEN
{
    public class Werknemers
    {
        public enum ContractTypes { FuulTime, PartTime };
        public Dictionary<string, int> Hours = new Dictionary<string, int>()
        {
            {"Full time",38 },
            {"Part Time",25},
        };



        public string Name { get; set; }
        public DateTime BornDate { get; set; }
        public string RRN { get; set; }
        public string Sex { get; set; }
        public double BruttoLoon { get; set; }
        public ContractTypes TypeContract { get; set; }
        public bool CompannyCar { get; set; }
        public DateTime DateOfStart { get; set; }
        public string Functie { get; set; }

        public Werknemers()
        {
        }

        public Werknemers(string name, DateTime bornDate, string rRN, string sex, double bruttoLoon = 1900, ContractTypes typeContract = ContractTypes.FuulTime, DateTime dateOfStart ) //hear mijn programma begin te klagen 
        {
            Name = name;
            BornDate = bornDate;
            RRN = rRN;
            Sex = sex;
            BruttoLoon = bruttoLoon;
            TypeContract = typeContract;
            CompannyCar = false;
            DateOfStart = dateOfStart;
            Functie = "Werknemer";
        }
        public double StartLoon()
        {
            double startLoon = 0;
            startLoon = Hours[TypeContract.ToString()] / 38 * BruttoLoon;
            return Math.Round(startLoon,2);
        }
        public double YearsExpirience()
        {
            double expiriance = DateTime.Now.Year - DateOfStart.Year;
            return expiriance;
        }
    }
}
