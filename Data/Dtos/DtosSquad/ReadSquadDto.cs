using VortiDex.Model;

namespace VortiDex.Data.DtosSquad;

public class ReadSquadDto
{
    public required int Id { get; set; }

    public required string Name { get; set; }

    public required int TrainerId { get; set; }

    public required ICollection<Pokemon> Pokemons { get; set; }
}
