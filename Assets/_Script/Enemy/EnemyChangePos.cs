using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChangePos : MonoBehaviour
{

    [SerializeField] Transform[] pos;
    [SerializeField] GameObject enemy;


    

    public void ChangeEnemyPosition()
    {
        enemy.transform.position = pos[Random.Range(0,pos.Length)].position;
    }




}
