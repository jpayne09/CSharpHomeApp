using System;
using System.Collections.Generic;
using System.Text;

namespace Home
{
    public abstract class HomeBase
    {
        private string HomeType { get; set; }
        private string MaintenanceFee { get; set; }
        private string HomeInsurance { get; set; }



        public abstract void getHomeInsuranceFee(double inFee);
        public abstract void getMaintenanceFee(double homeFee);
    }
}
