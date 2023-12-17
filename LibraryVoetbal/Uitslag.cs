using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
namespace LibraryVoetbal
{
    public class Uitslag
    {
      public string thuisPloeg
        {
            get; set;
        }
        public int doelpuntenThuis
        {
            get;set;
        }
        public string uitPloeg
        {
            get; set;
        }
        public int doelpuntenUit
        {
            get;set;
        }
    }
}
