using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;



public class ChangeTargetValues : MonoBehaviour
{
    public List<TargetValues> targetValues;

    [SerializeField] private List<Target> target;


        
    private void Awake() 
    {
       foreach (Target item in transform.GetComponentsInChildren<Target>()) target.Add(item);
    }

    

    public void ChangeOrder()
    {
        //shuffle ba�ka bi cs'de, ger�ek bi programc� gibi internetten �ald�m 
        targetValues.Shuffle(3);

        for (int i = 0; i < target.Count; i++)
        {
            target[i].targetPoint = targetValues[i].targetPoint;
            target[i].GetComponent<MeshRenderer>().material = targetValues[i].targetMaterial;
        }
       
    }

    
}
