﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeMvc.Models
{
    public class Country
    {
        public int cou_Id { get; set; }
        public string cou_Name { get; set; }

        public virtual tbl_city tb_city { get; set; }
    }
}