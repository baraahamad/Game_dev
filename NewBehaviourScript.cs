using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    { 
      
        System.Random random = new System.Random();
        
        while (true)
        {
            
            int number = random.Next(1, 21);

            if (number == 5)
            {
                continue;
            }

            Debug.Log("Generated Number: " + number);

            if (number == 15)
            {
                Debug.Log(" 15 exiting loop.");
                break;
            }
        }
    }

     
}
