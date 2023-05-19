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
        for(int room = 1; room < 5 ; room++)
        {
            Debug.Log ($"Вы вошли в комнату {room}");
            if (room==TargetRoom)
            {
            Debug.Log($"Вы нашли нужную комнату! Номер комнаты {room}");
            break;
            }
            else
            {
                for (int ugol=1; ugol<5;ugol++)
                {
                    Debug.Log ($"Вы посмотрели в угол №{ugol}");
                }
            }
            Debug.Log($"Вы вышли из комнаты {room}");


            
        }
        Debug.Log("Вы окончили осмотр комнат!");



    }

   
}

    
