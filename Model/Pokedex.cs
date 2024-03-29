﻿using System.ComponentModel.DataAnnotations;

namespace VortiDex.Model;

public class Pokedex
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public int TrainerId { get; set; }

    public Trainer Trainer { get; set; }

    public ICollection<Pokemon> Pokemons { get; set; }

    public Pokedex()
    {
        Pokemons = new List<Pokemon>();
    }
}
