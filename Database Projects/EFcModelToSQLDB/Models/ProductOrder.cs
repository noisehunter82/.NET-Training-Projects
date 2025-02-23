using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFcModelToSQLDB.Models
{
    public class ProductOrder
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public required Order Order { get; set; }

        public required Product Product { get; set; }
    }
}