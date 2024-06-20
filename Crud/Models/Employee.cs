using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Models
{
    public class Employee
    {



        // guid---------Globally unique identifier

        public Guid emailID { get; set; }

        //-----?--- make it nullable property
        public required string? Name { get; set; }
        public required string? country { get; set; }
        public string? state { get; set; }
        public string? city { get; set; }


        public long telephoneNumber { get; set; }

        public string? addressLine1 { get; set; }
        public string? addressLine2 { get; set; }




        public int grossSalaryFY201920 { get; set; }
        public int grossSalaryFY202021 { get; set; }
        public int grossSalaryFY202122 { get; set; }
        public int grossSalaryFY202223 { get; set; }
        public int grossSalaryFY202324 { get; set; }

        public DateOnly Date { get; set; }

    }

}