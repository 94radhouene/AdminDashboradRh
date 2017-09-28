﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace AdminDashboradRh.Models
{
    public class RhContext : DbContext
    {
        public RhContext()
            : base("name=RhAppContext")
        {
        }



        public virtual DbSet<UserApp> Users { get; set; }
       
        public class Userviewmodel
        {
            public UserApp user { get; set; }
        }
        public class Employeeviewmodel
        {
            public EmployeeApp Employee { get; set; }
        }
     
    }
}