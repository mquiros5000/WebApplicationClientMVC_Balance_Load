using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationClientMVC.Models
{
    public  class Balance
    {
        public  Load load { get; set; }

        public  IEnumerable<Plant_Power> _listPlantPower = new List<Plant_Power>();
        public  IEnumerable<Plant_Power> listPlantPower
        {
            get
            {
                return _listPlantPower;
            }
            set
            {
                _listPlantPower = value;
            }
        }
        public Plant_Power BestPlantPower { get; set; }
        public double Total { get; set; }
        public double Difference { get; set; }
        public double Units { get; set; }
        public double BalanceResult { get; set; }
    }
}