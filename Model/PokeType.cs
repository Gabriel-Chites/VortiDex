using System.ComponentModel.DataAnnotations;

namespace VortiDex.Model;

public class PokeType
{
    [Key]
    [Required]
    public string Name { get; set; }
    public ICollection<Pokemon> Pokemon { get; set; }
    public ICollection<Skill> Skills { get; set; }

}
