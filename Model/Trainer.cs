using System.ComponentModel.DataAnnotations;

namespace VortiDex.Model;

public class Trainer
{

    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public Pokedex Pokedex { get; set; }

    public ICollection<Squad> Squads { get; set; }

    public Trainer()
    {
        Squads = new List<Squad>();
    }
}
