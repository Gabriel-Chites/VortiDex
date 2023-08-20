using VortiDex.Model;

namespace VortiDex.Data.DtosSkill;

public class UpdateSkillDto
{
    public required string Name { get; set; }

    public required string Description { get; set; }

    public required PokeType Type { get; set; }
}
