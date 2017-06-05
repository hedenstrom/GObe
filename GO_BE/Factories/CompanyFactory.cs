using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GO_BE.Models;

namespace GO_BE.Factories
{
    public static class CompanyFactory
    {
        public static Company GetCompany()
        {
            return new Company {Name = "Hedenström Trading HB"};

        }
    }
}