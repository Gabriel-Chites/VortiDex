using System.ComponentModel.DataAnnotations;
using VortiDex.Model;

namespace VortiDex.Data.Dtos.DtosPokeType;

public class ReadPokeTypeDto
{
    public required string Name { get; set; }
    public required ICollection<Pokemon> Pokemon { get; set; }
    public required ICollection<Skill> Skills { get; set; }
}
