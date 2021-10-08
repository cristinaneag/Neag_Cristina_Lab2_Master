using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Neag_Cristina_Lab2_Master.Models
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
