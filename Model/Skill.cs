using System.ComponentModel.DataAnnotations;
using VortiDex.Enums;

namespace VortiDex.Model;

public class Skill
{
    [Key]
    [Required] 
    public int Id { get; set; }

    [Required] 
    public string Name { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public PokeType Type { get; set; }  

    public ICollection<Pokemon> Pokemons { get; set; }

    public Skill()
    {
        Pokemons = new List<Pokemon>();
    }
}
