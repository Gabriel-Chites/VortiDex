using System.ComponentModel.DataAnnotations;

namespace VortiDex.Model;

public class Squad
{

    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public int TrainerId { get; set; }

    public Trainer Trainer { get; set; }

    public ICollection<Pokemon> Pokemons { get; set; }

    public Squad()
    {
        Pokemons = new List<Pokemon>();
    }
}
