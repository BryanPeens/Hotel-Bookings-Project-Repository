using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Project2
{
    [Serializable]
    public class Suite
    {
        private string suiteName;
        private string description;
        private int maxPatrons;
        private double costpppn;

        public string SuiteName { get => suiteName; set => suiteName = value; }
        public string Description { get => description; set => description = value; }
        public int MaxPatrons { get => maxPatrons; set => maxPatrons = value; }
        public double Costpppn { get => costpppn; set => costpppn = value; }

        public Suite(string suiteName, string description, int maxPatrons, double costpppn)
        {
            this.suiteName = suiteName;
            this.description = description;
            this.maxPatrons = maxPatrons;
            this.costpppn = costpppn;
        }

        public Suite()
        {
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}",SuiteName,Description,MaxPatrons,Costpppn);
        }
    }
}
