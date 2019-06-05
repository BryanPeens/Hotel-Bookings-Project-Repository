using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class SuiteOption
    {
        private int optionID;
        private string optionName;
        private decimal optionPrice;
        private bool perDay;

        public string OptionName { get => optionName; set => optionName = value; }
        public decimal OptionPrice { get => optionPrice; set => optionPrice = value; }
        public int OptionID { get => optionID; set => optionID = value; }
        public bool PerDay { get => perDay; set => perDay = value; }

        public SuiteOption(int optionID, string optionName, decimal optionPrice, bool perDay)
        {
            this.optionID = optionID;
            this.optionName = optionName;
            this.optionPrice = optionPrice;
            this.perDay = perDay;
        }
    }
}

/*
 * 
 * 
 * CREATE TABLE [dbo].[tblSuiteOptions](
	[optionID] [int] IDENTITY(1,1) NOT NULL,
	[optionName] [nvarchar](500) NOT NULL,
	[optionPrice] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_tblSuiteOptions] PRIMARY KEY CLUSTERED 
*/