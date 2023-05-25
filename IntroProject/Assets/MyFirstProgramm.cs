using System.Runtime.InteropServices.ComTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstProgramm : MonoBehaviour
{
    /*
    //Процедурное программирование - это когда иснтрукции выполняются последовательно группируясь в методы


    string heroName = "Ilya";
    int heroHp = 100;
    int heroDamage = 20;

    string enemyName = "Vrag";
    int enemyHp = 50;
    int enemyDamage = 10;


    void Start()
    {
        for (int battleTurn = 1; battleTurn<5; battleTurn++)
        {
            Debug.Log($" раунд {battleTurn} начинается!");
            PrintAttack (enemyName,heroName);
            heroHp-=enemyDamage;
            if (heroHp<=0)
            {
                Debug.Log($"{heroName} погибает!");
                break;
            }
            else
            {
                PrintHp (heroName, heroHp);
            }
            PrintAttack (heroName, enemyName);
            enemyHp-=heroDamage;
            if (enemyHp<=0)
            {
                Debug.Log ($"{enemyName} погибает!");
                break;
            }
            else PrintHp (enemyName, enemyHp);
            
        }

    }

    public void PrintAttack (string Attacker, string Deffender)
    {
        Debug.Log ($"{Deffender} был атакован {Attacker}!");

    }

    public void PrintHp (string name, int hp)
    {
        Debug.Log ($" у {name} осталось {hp} очков здоровья");
    }
       
    */

    
    private void Start ()
    {
        //инициализаця переменных нового класса
        //это так же называется контест исполнения
        ActorWithBuff hero = new ActorWithBuff ("Ilya", 40, 10, 12);
        Actor [] enemies = {new Actor ("Vrag", 50, 10), new Actor ("Drug", 80, 15), new Actor ("Svoi", 40, 8)};
        
        Debug.Log("Let's mortalcombat begin!");

        for (int turn=1; turn<5; turn++)
        {            
            Debug.Log ($"Раунд {turn} начинается!");
            bool isHeroDead = false;
            bool isAllEnemiesDead = true;

            foreach (Actor enemy in enemies)
            {
                if (enemy.IsDead()) continue;
                isHeroDead = Attack (enemy, hero);
                if (isHeroDead) break;
                //hero attack enemy
                hero.UseBuff();  //герой бафается перед атакой
                var isEnemyDead = Attack (hero, enemy);
                isAllEnemiesDead = isAllEnemiesDead && isEnemyDead;                
            }
            if (isHeroDead || isAllEnemiesDead) break;
        }
    }

    //Метод атаки
    public bool Attack (Actor attacker, Actor deffender)
    {
        deffender.Hp-=attacker.Damage;
         Debug.Log ($"{deffender.Name} был атакован {attacker.Name}!");
         bool isDead = deffender.IsDead();
         if (isDead)
         {
            PrintDead (deffender, attacker);
         }
         else PrintHp (deffender.Name, deffender.Hp );
         return isDead;                 
    }
    
    public void PrintDead (Actor deffender, Actor attacker)
    {
        Debug.Log ($"{deffender.Name} был убит {attacker.Name}");
    }

    public void PrintHp (string name, int hp)
    {
        Debug.Log ($" у {name} осталось {hp} очков здоровья");
    }

}

// новый класс Эктора
// он называется АБСТРАКЦИЯ
public class Actor
{
    public string Name;
    public int Hp;
    public int Damage;

    //ниже конструктор
    public Actor (string name, int hp, int damage)
    {
        Name = name;
        Hp = hp;
        Damage = damage;
        Debug.Log ($"В битву вступант игрок {Name}");
        
    }  

    // выше конструктор

    public bool IsDead()
    {
        return Hp<=0;
    }

}

public class ActorWithBuff : Actor //Создание наследника
{
    int BuffValue;
    //В конструкторе обязательно указываем базовые параметры от родителя
    public ActorWithBuff (string name, int hp, int damage, int buffValue) : base (name, hp, damage)
    {
        BuffValue = buffValue;
    }

    //метод бафа
    public void UseBuff ()
    {
     Damage +=BuffValue;
     Debug.Log ($"{Name} издает воинственный клич! Урон увеличен на {BuffValue}");   
    }
}
