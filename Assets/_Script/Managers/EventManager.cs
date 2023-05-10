using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public static EventManager instance;

    private void Awake()
    {
        instance = this;
    }

    [System.Serializable] public class TargetCollected : UnityEvent<int> { }
    [System.Serializable] public class EnemyHit : UnityEvent { }
    [System.Serializable] public class EnemyPass : UnityEvent { }

    public TargetCollected onTargetCollected;
    public EnemyHit onEnemyHit;
    public EnemyPass onEnemyPass;
    
    

}
