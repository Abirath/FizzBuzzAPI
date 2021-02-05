using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Models
{
    [Table("FizzBuzzStoretbl")]
    public class FizzBuzzStore
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FizzBuzzStoreID { get; set; }

        public string FizzBuzzValue { get; set; }
    }
}
