using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beginnining : MonoBehaviour
{
    string HeroName = "Stickman";
        int HeroHight = 2;
       int HeroAge = 123;
        string HeroSuperPower = "holding a fancy stick";

        string VillainName = "HandsomePenguin";
        float VillainHight = 1.75f;
        int VillainAge = 201;
        string VillainSuperPower = "Stun you using PANCAKES";

         






    // Start is called before the first frame update
    void Start()
    {
        int AgeDifference = VillainAge - HeroAge;

        print("The name is "+HeroName+" he is "+HeroHight+"m long and Legends say that he is "+HeroAge+" years old and he is "+HeroSuperPower+"!");

        print("And we have a "+VillainName+" Who ages "+VillainAge+" penguin years and he is "+VillainHight+"m tall but becarful he can "+VillainSuperPower+"!?");




        print(AgeDifference);
        print(HeroHight+5);
        
        {
            string VillainSuperPower = "None";

         print("The name is "+HeroName+" he is "+HeroHight+"m long and Legends say that he is "+HeroAge+" years old and he is "+HeroSuperPower+"!");

         print("And we have a "+VillainName+" Who ages "+VillainAge+" penguin years and he is "+VillainHight+"m tall but he has "+VillainSuperPower+" superpower so he is harmless");


        }
        
        
        
    }


    // Update is called once per frame
    void Update()
    {
        


    }
}
