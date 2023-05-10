using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    
    private VariableJoystick joystick;
    private Transform PlayerBodyTransform;
    

    [SerializeField]
    private float turnSpeed;

    private float posLimit;

    private Vector3 pos = Vector3.zero;

    
    void Start()
    {       
        PlayerBodyTransform = transform.GetChild(0).transform;
        
        joystick = GameObject.FindGameObjectWithTag("JoyStick").GetComponent<VariableJoystick>();
        posLimit = 1.2f;
    }

    
    void Update()
    {
        MoveHorizontal();   
        
    }

    void MoveHorizontal()
    {
        pos = PlayerBodyTransform.localPosition;
        pos += Vector3.up * joystick.Horizontal * Time.deltaTime * turnSpeed;
        pos.y = Mathf.Clamp(pos.y, -posLimit, posLimit);
        PlayerBodyTransform.localPosition = pos;

    }

   

}
