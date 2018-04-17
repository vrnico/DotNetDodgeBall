using System.ComponentModel.DataAnnotations;


namespace DodgeBall.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        public string Name { get; set; }
        public int DivisionId { get; set; }
        public virtual Division Division { get; set; }
    }
}