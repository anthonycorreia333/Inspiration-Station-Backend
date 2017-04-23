using System;
using System.Collections.Generic;
using System.Data.Entity;
using InspirationStation1.Api.Models;
using System.Linq;
using System.Web;

namespace InspirationStation1.Api.Infrastructure
{
    public class InspirationStationDataContext : DbContext
    {
        public InspirationStationDataContext() : base("Applications")
        {
               
        }
        public IDbSet<Application> Applications { get; set; }

    }
}