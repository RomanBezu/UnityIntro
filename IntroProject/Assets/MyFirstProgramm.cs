using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstProgramm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(3);
        //Debug.Log(2);
        //Debug.Log(1);

        //Debug.Log("Hello world!");
        int Health = 100;
        int Damage=20;
        int Recharge=30;


        Health -= Damage;
        Debug.Log("Current health is "+ Health);

        Health -= Damage;
        Debug.Log("Current health is "+ Health);
        
        Health+=Recharge;
        Debug.Log ("Current hp is" + Health);
        



    }
}

    
