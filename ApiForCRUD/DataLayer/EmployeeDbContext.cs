﻿using ApiForCRUD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiForCRUD.DataLayer
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext() : base("EmployeeDbContext")
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}