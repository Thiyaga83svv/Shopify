using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shopify.Model
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Firsname { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Lastname { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Address { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string State { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string City { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int Postcode { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int PhoneNumber { get; set; }
    }
}
