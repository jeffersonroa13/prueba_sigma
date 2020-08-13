using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prueba_sigma.Models
{
    [Table("contacts")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set;  }
        [Column("name")]
        public string Name { get; set;  }
        [Column("email")]
        public string Email { get; set; }
        [Column("state")]
        public string State { get; set;  }
        [Column("city")]
        public string City { get; set;  }

    }
}
