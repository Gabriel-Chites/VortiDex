using System.ComponentModel.DataAnnotations;
using System.Globalization;
using VortiDex.Enums;

namespace VortiDex.Model;

public class Pokemon
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required] 
    public string Name { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public double Height { get; set; }

    [Required]
    public double Weight { get; set; }

    [Required]
    public bool IsCatch { get; set; }

    [Required]
    public string Picture { get; set; }

    [Required]
    public PokeType[] PokeTypes { get; set; } = new PokeType[2];

    public ICollection<Squad> Squads { get; set; }

    public ICollection<Skill> Skills { get; set; }

    public Pokemon()
    {
        Squads = new List<Squad>();
        Skills = new List<Skill>();
    }
}
