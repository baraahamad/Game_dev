using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
public class Character
{
    private string name;
    private int health;

   
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Health
    {
        get { return health; }
        set { health = value < 0 ? 0 : (value > 100 ? 100 : value); } // Manually clamping health between 0 and 100
    }

    
    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }
}

