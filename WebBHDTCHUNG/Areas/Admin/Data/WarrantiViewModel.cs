﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBHDTCHUNG.Models;
using WebBHDTCHUNG.Models;

namespace WebBHDTCHUNG.Areas.Admin.Data
{
    public class WarrantiViewModel:ProductWarranti
    {
        public string ProductName { get; set; }
        public string Serial { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerProvince { get; set; }
        //public string CustomerInstallationAgentAddress { get; set; }
        //public string CustomerCarBrandname { get; set; }
    }
}