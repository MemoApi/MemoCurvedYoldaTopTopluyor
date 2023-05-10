using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour, IHitable
{

    public int targetPoint;


    public void Hit()
    {
        EventManager.instance.onTargetCollected.Invoke(targetPoint);

    }
}
