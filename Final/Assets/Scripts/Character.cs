using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Custom class object
public class Character //creates a class called Character
{
    // Class fields
    public string name; // initiates a string variable
    public int exp = 0; // defines an integer variable

    // Class constructor
    public Character() // makes a Character constructor with no arguments
    {
        name = "Not assigned"; // assigns Character method name variable
    }

    public Character(string name) // makes a Character constructor that takes a string argument
    {
        this.name = name; // adds value of input to Character.name
    }

    // Class methods
    public virtual void PrintStatsInfo() // outputs stat info, can be changed by children class with override
    {
        Debug.LogFormat("Hero: {0} - {1} EXP", name, exp);
    }

    // Private methods
    private void Reset() // can only be called in the class, private method
    {
        this.name = "Not assigned";
        this.exp = 0;
    }
}

public class Paladin : Character // inherits from Character class
{
    public Weapon weapon;

    public Paladin(string name, Weapon weapon) : base(name) // Paladin Constructor
    {
        this.weapon = weapon;
    }

    public override void PrintStatsInfo() // Similar to Character.PrintStatsInfo()
    {
        Debug.LogFormat("Hail {0} - take up your {1}!", name,
        weapon.name);
    }
}

public struct Weapon // initiates struct, similar to classes in sense of creating objects, but is passed by value instead of reference
{
    public string name;
    public int damage;

    public Weapon(string name, int damage) // weapon constructor
    {
        this.name = name;
        this.damage = damage;
    }

    public void PrintWeaponStats() // similar to Character.PrintStatsInfo()
    {
        Debug.LogFormat("Weapon: {0} - {1} DMG", name, damage);
    }
}