using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace DodgeBall.Models
{
    public class Division
    {
        [Key]
        public int DivisionId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }

}

