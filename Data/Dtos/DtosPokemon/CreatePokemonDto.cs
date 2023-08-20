using System.ComponentModel.DataAnnotations;
using VortiDex.Model;

namespace VortiDex.Data.Dtos.DtosPokemon;

public class CreatePokemonDto
{
    public required string Name { get; set; }

    public required string Description { get; set; }

    public double Height { get; set; }

    public double Weight { get; set; }

    public bool IsCatch { get; set; }

    public required string Picture { get; set; }

    public PokeType[] PokeTypes { get; set; } = new PokeType[2];
}
