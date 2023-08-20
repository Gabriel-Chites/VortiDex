using System.ComponentModel.DataAnnotations;
using VortiDex.Model;

namespace VortiDex.Data.Dtos.DtosPokedex;

public class ReadPokedexDto
{
    public int Id { get; set; }

    public required Trainer Trainer { get; set; }

    public required ICollection<Pokemon> Pokemons { get; set; }
}
