global using System.Text.Json;

Weapon FirstWeapon = new Weapon()
{
    Name = "Katana",
    MinDmg = 5,
    MaxDmg = 10
};

string jsonWeapon = JsonSerializer.Serialize(FirstWeapon);
System.Console.WriteLine(jsonWeapon);
File.WriteAllText("weapons.json", jsonWeapon);

Console.ReadLine();