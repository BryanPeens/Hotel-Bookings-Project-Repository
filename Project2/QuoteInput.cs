using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class QuoteInput
    {
        private string name;
        private string surname;
        private string id;
        private string telNumber;
        private int numberOfPatrons;
        private int numOfDays;
        private string address;
        private List<SuiteOption> suiteOptions;
        private Suite suite;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Id { get => id; set => id = value; }
        public string TelNumber { get => telNumber; set => telNumber = value; }
        public int NumberOfPatrons { get => numberOfPatrons; set => numberOfPatrons = value; }
        public int NumOfDays { get => numOfDays; set => numOfDays = value; }
        public string Address { get => address; set => address = value; }
        public List<SuiteOption> SuiteOptions { get => suiteOptions; set => suiteOptions = value; }
        public Suite Suite { get => suite; set => suite = value; }

        public QuoteInput(string name, string surname, string id,
            string telNumber, int numberOfPatrons, int numOfDays,
            string address, List<SuiteOption> suiteOptions, Suite suite)
        {
            this.name = name;
            this.surname = surname;
            this.id = id;
            this.telNumber = telNumber;
            this.numberOfPatrons = numberOfPatrons;
            this.numOfDays = numOfDays;
            this.address = address;
            this.suiteOptions = suiteOptions;
            this.suite = suite;
        }

        public double calculateBasic()
        {
            //basic = numberofPatrons * costperPatron * days
            double result = this.numberOfPatrons * this.suite.Costpppn * this.NumOfDays;

            return result;

        }


        public string generateQuote()
        {
            var str = this.quoteTemplate.ToString();

            str = str.Replace("#####SUITE_NAME#####", this.suite.SuiteName.ToUpper());
            str = str.Replace("#####NAME_Value#####", this.name);
            str = str.Replace("#####SURNAME_Value#####", this.surname);
            str = str.Replace("#####ID_Value#####", this.id);
            if (this.telNumber.Trim() == "")
            {
                str = str.Replace("#####Number_Value#####", "NONE");
            }
            else
            {
                str = str.Replace("#####Number_Value#####", this.telNumber);
            }
            str = str.Replace("#####Address_Value#####", this.address);
            str = str.Replace("#####Patron_number#####", this.numberOfPatrons.ToString());
            str = str.Replace("#####Patron_price#####", this.suite.Costpppn.ToString());
            str = str.Replace("#####Day_number#####", this.NumOfDays.ToString());
            str = str.Replace("#####Basic#####", calculateBasic().ToString());

            double totalCost = calculateBasic();

            if (this.suiteOptions.Count == 0)
            {
                str = str.Replace("#####additional_Options#####", "NONE");
            }
            else
            {
                string additionalOption = "";

                foreach (var item in this.suiteOptions)
                {
                    double addedCost = Convert.ToDouble(item.OptionPrice);

                    string perDayString = "" ;
                    if (item.PerDay == true)
                    {
                        addedCost = addedCost * this.NumOfDays * this.numberOfPatrons; ;
                        perDayString += " p/p/p/d";
                    }

                    totalCost += addedCost;

                    additionalOption += item.OptionName + "     @ R" + item.OptionPrice + perDayString + Environment.NewLine;
                }

                str = str.Replace("#####additional_Options#####", additionalOption);
            }
            str = str.Replace("#####Total_Cost#####", totalCost.ToString());

            return str;
        }

        private string quoteTemplate = @"
                                                            HOTEL PERFECT
                                                            ==================
                                                            #####SUITE_NAME#####
                                                            ==================

Name : #####NAME_Value#####                                     Surname : #####SURNAME_Value#####
ID Number : #####ID_Value#####                                  Telephone Number : #####Number_Value#####
                                                                Address :
                                                                #####Address_Value#####

The number of Patrons is #####Patron_number##### @ R#####Patron_price##### Per Person
Number of Days : #####Day_number#####

Basic : R#####Basic#####

Additional Options
#####additional_Options#####

Total Cost is : R#####Total_Cost#####

";
    }
}


