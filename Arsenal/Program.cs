﻿global using System.Text.Json;

string qwe = File.ReadAllText("weapons.json");

Weapon qwer = JsonSerializer.Deserialize<Weapon>(qwe);

// System.Console.WriteLine(qwer.MinDmg);
System.Console.WriteLine("Insert desired amount of attacks");
string NumAttack = Console.ReadLine();
int AmountAttack = int.Parse(NumAttack);

int Sumdmg = 0;


for(int i = 0; i < AmountAttack; i++)
{
    int damage = qwer.Attack();
    Sumdmg += damage;
}

System.Console.WriteLine($"{Sumdmg} damage inflicted");



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