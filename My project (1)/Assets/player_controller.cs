using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : player
{
    int hp;
    int power;

    public player(int hp, int power)
    {
        this.hp = hp;
        this.power = power;
    }
    public void Damage(int damage)
    {
        this.hp -= damage;
    }
}
