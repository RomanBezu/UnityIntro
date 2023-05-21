using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstProgramm : MonoBehaviour
{
 
 /*
 [SerializeField] string itemTofound;
 [ContextMenu ("Find item")]
        void FindItem ()
        {
             string [] inventory = {"меч", "монета","топор", "хлам", "хвост", "меч", "монета","топор", "хлам", "хвост"};

             bool itemFound = false;
             int itemcount=0;

             foreach ( string item in inventory)
             {
                
                if (item==itemTofound)
                {
                    itemFound=true;
                    itemcount ++;
                    
                }
             } 

             if (itemFound)
             {
                Debug.Log ($"Предмет {itemTofound} найден, колество {itemcount} штук!");
             }  
             else 
             Debug.Log ($"Предмет {itemTofound} не найден в инвентаре!");
        }
    */


    // Start is called before the first frame update
    int MyHealth=50;
    void Start()
    {
        Debug.Log ($"Старотовое здоровье {MyHealth}");
                
        EatApples (3,true);
        EatApples (2,false);
        EatApples (1,true);




    }

    private void EatApples (int Count, bool IsTasty)
    {
        if (IsTasty)
        Debug.Log ($"Вы съели {Count} яблок и они были вкусные");
        else
        {
        Debug.Log ($"Вы съели {Count} яблок и они были невкусные");
        }
        Healing (Count, IsTasty);
        Debug.Log ($"У вас осталось {MyHealth} здоровья");

    }

    private int Healing (int count, bool IsTasty)
    {
        if (IsTasty)
        {
            MyHealth+=10*count;
           // Debug.Log ("ммм..вкуснятина");
        }
        else
        {
            MyHealth-=15*count;
            //Debug.Log ("Тьфу гадость");

        }
        return MyHealth;


    }
        
       

        
        
        
        
        
        
        
        
        /*
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

        */

        /*
        int [] numbers = { 21, 34, 162, 97, 456};
        Debug.Log ($"Длинна массива {numbers.Length}");

        foreach (int item in numbers)
        {
            Debug.Log ($"Элемент равен {item}");

        }
        */



        /*
        for (int index=0; index<numbers.Length; index++)
        {
            int item = numbers [index];
            Debug.Log ($"Элемент номер {index} равен {item}");

        }

        
        numbers [0] = 21;
        numbers [1] =34;
        numbers [2] = 162;
        numbers [3] = 97;
        numbers [4] = 456;
        

        var second  = numbers [2];
        Debug.Log ($"Значение третьего элемента равно {second}");
        */






   

   
}

    
