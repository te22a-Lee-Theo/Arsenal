global using System.Text.Json;

string qwe = File.ReadAllText("weapons.json");

Weapon qwer = JsonSerializer.Deserialize<Weapon>(qwe);

System.Console.WriteLine(qwer.MinDmg);


Console.ReadLine();
// Weapon FirstWeapon = new Weapon()
// {
//     Name = "Katana",
//     MinDmg = 5,
//     MaxDmg = 10
// };

// string jsonWeapon = JsonSerializer.Serialize(FirstWeapon);
// System.Console.WriteLine(jsonWeapon);
// File.WriteAllText("weapons.json", jsonWeapon);