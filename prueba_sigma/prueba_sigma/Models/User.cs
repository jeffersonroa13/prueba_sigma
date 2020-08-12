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
        public int Id { get; set;  }
        public string Name { get; set;  }
        public string Email { get; set; }
        public bool State { get; set;  }
        public string City { get; set;  }

    }
}
