using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
      
        Player player1 = new();
        Player player2 = new();

       
        player1.InitializePlayer("Player One", 80);
        player2.InitializePlayer("Player Two", 90);

        
        player1.Heal(10);           
        player2.Heal(true);         

        Player.ShowPlayerCount();
    }
}
