using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IHitable
{
    public void Hit()
    {
        EventManager.instance.onEnemyHit.Invoke();
    }

    
}
