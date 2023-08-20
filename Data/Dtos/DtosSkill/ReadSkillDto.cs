using VortiDex.Model;

namespace VortiDex.Data.DtosSkill;

public class ReadSkillDto
{
    public required int Id { get; set; }

    public required string Name { get; set; }

    public required string Description { get; set; }

    public required PokeType Type { get; set; }

    public required ICollection<Pokemon> Pokemons { get; set; }
}
