using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Third_day : MonoBehaviour
{

    string heroName = "Mario";
    int heroPower = 90;

    string villianName = "Joker";
    int villianPower = 80;

    float playerSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        if(heroPower > villianPower)
        {
            print(heroName + " is stronger than " + villianName);
        }
        else if(heroPower < villianPower)
        {
            print(villianName + " is stronger than " + heroName);
        }   
        else
        {
            print(heroName + " is as strong as " + villianName);
        }


        print("The old player speed is " + playerSpeed);
        SetSpeed(2.5f);
        print("The new player speed is " + playerSpeed);

    }

        void SetSpeed(float speed)
    {
        playerSpeed = speed;
       
    }
   

}
