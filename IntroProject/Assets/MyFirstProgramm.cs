using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstProgramm : MonoBehaviour
{

       [SerializeField] string Enemy;


    // Start is called before the first frame update
    void Start()
    {
        int TargetRoom = 2;
        Debug.Log("Вы начинаете осмотр комнат");
        for(int Room = 1; Room < 5 ; Room++)
        {
            Debug.Log ($"Вы вошли в комнату {Room}");
            if (Room==TargetRoom)
            {
            Debug.Log($"Вы нашли нужную комнату! Номер комнаты {Room}");
            break;
            }
            else
            {
                for (int ugol=1; ugol<5;ugol++)
                {
                    Debug.Log ($"Вы посмотрели в угол №{ugol}");
                }
            }
            Debug.Log($"Вы вышли из комнаты {Room}");


            
        }
        Debug.Log("Вы окончили осмотр комнат!");



    }

   
}

    
