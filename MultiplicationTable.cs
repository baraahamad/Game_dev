using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int number = 5;
        
        for (int i = 1; i <= 10; i++)
        {
            int result =Multiply(number, i);
            Debug.Log($"{number} x {i} = {result}");
        }
        
    }
     int Multiply(int a, int b)
    {
        return a * b;
    }

}
