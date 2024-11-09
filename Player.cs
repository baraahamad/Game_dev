using UnityEngine;

public class Player
{
    public string playerName;
    public int health;

   
    public static int playerCount = 0;

    
    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        playerCount++; 
    }

   
    public void Heal(int amount)
    {
        health += amount;
        Debug.Log($"{playerName} healed by {amount}. New health: {health}");
    }

    
    public void Heal(bool fullRestore)
    {
        if (fullRestore)
        {
            health = 100;  
            Debug.Log($"{playerName} fully healed. New health: {health}");
        }
    }

    public static void ShowPlayerCount()
    {
        Debug.Log($"Total number of Player objects: {playerCount}");
    }
}
