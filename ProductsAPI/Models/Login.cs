using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAPI.Models
{
    public class Login
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int userId { get; set; }
        [MaxLength(50)]
        public string userName { get; set; }
        [MaxLength(50)]
        public string password { get; set; }
    }
}
