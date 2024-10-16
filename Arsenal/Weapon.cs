using System.Text.Json.Serialization;
using System.Xml.Serialization;

public class Weapon
{
    [JsonInclude]
    public string Name;
    [JsonInclude]
    public int MinDmg;
    [JsonInclude]
    public int MaxDmg;

    // public int Attack()
    // {

    // }
}
