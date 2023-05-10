using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPass : MonoBehaviour, IHitable
{
    public void Hit()
    {
        EventManager.instance.onEnemyPass.Invoke();
    }
}
