using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    { 
      
        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };

        string sentence = "";

        int wordCount = 0;

        System.Random random = new System.Random();

        while (wordCount < 7)
        {
            string randomWord = words[random.Next(words.Length)];

            sentence += randomWord + " ";

            wordCount++;
        }

        Debug.Log("Funny Sentence: " + sentence.Trim());
    
    }

     
}
