using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoring
{
    class villians
    {
        //fields
        private string costumes;
        private string name;
        private string evilPowers;
        private int strengthLevel;

        //properties
        public string Costumes { get; set; }
        public string Name { get; set; }
        public string EvilPowers { get; set; }
        public int StrengthLevel { get; set; }

        //contractors
        public villians()
        {
            Random random = new Random();
            this.costumes = " A bed sheet";
            this.name = "A really bad dude";
            this.evilPowers = "I can control empty boxes";
            this.strengthLevel = random.Next(0, 51);
        }

        public villians(string name, string costumes, int strengthLevel)
        {
            this.name = name;
            this.costumes = costumes;
            this.evilPowers = GetPowers();
            this.strengthLevel = strengthLevel;
        }

        //methods
        public string GetPowers()
        {
            string[] powers = { " Killer Farts", "Mind Control", "Throwing Fire", "Words that can kill" };
            {
                Random random = new Random();
                string newPower = powers[random.Next(0, powers.Length)];
                return newPower;
            }

        }

    }
}
