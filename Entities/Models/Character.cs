using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Character
{
    public int CharacterId { get; set; }

    [Required(ErrorMessage = "A name is required")]
    public string Name { get; set; } = "Nameless";
    public int Level { get; set; }

    [Required(ErrorMessage = "A class is required")]
    public string Class { get; set; } = string.Empty;
    public string? Archetype { get; set; }
    public string? Background { get; set; }
    public string? Alignment { get; set; }

    // Need to reformat this
    public int STR { get; set; }
    public int DEX { get; set; }
    public int CON { get; set; }
    public int INT { get; set; }
    public int WIS { get; set; }
    public int CHA { get; set; }
}