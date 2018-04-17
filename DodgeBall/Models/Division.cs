using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DodgeBall.Models
{
    [Table("Divisions")]
    public class Division
    {
        [Key]
        public int DivisionId { get; set; }
        public string Name { get; set; }
        public string SkillLevel { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }

}

