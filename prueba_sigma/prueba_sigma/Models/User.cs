using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prueba_sigma.Models
{
    [Table("Contacts")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id_contacts")]
        public int Id { get; set;  }
        [Column("Name")]
        public string Name { get; set;  }
        [Column("Email")]
        public string Email { get; set; }
        [Column("State")]
        public string State { get; set;  }
        [Column("City")]
        public string City { get; set;  }

    }
}
