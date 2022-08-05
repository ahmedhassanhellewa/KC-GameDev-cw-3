using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day3 : MonoBehaviour
{
    // hero biography 
    string heroname = " Dillon ";
    int heropower = 5;

    // villian biography 
    string villianname = " DR.K";
    int villianpower = 17;

    float playerspeed = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
     if (heropower > villianpower )
        {
            print(" the winner is " + heroname);
        }
     else if ( heropower == villianpower )
        {
            print(" they are equal ");
        }
     else
        {
            print("the winner is " + villianname);
        }
        setspeed(2.5f);
        comparespeed( 7.2f);
    }
        void setspeed ( float newspeed)
    {
        print(playerspeed);
        playerspeed = newspeed;
        print(playerspeed);
    }

    void comparespeed(float newspeed2)
    {
        if (playerspeed > newspeed2)
        {
            print(playerspeed);
        }
        else if (playerspeed == newspeed2)
        {
            print("the two speeds are equal");
        }
        else
        {
            print(newspeed2);
        }

    }

    // Update is called once per frame
    void Update()
    {
    
    }

}
