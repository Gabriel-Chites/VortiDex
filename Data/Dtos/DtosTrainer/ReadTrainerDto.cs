using System.ComponentModel.DataAnnotations;
using VortiDex.Model;

namespace VortiDex.Data.DtosTrainer;

public class ReadTrainerDto
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public required ICollection<Squad> Squads { get; set; }
}
