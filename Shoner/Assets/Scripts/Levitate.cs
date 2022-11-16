using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levitate : MonoBehaviour
{
    public GameObject robot;
    public float speed;
    public float rot;
    private float y;
    private float angleY;

    public void Start()
    {
        y = robot.transform.position.y;
        angleY = robot.transform.rotation.eulerAngles.y;
    }
  
    public void Update()
    {
        float x = robot.transform.position.x;
        float z = robot.transform.position.z;
        
        float angleX = robot.transform.rotation.eulerAngles.x; 
        float angleZ = robot.transform.rotation.eulerAngles.z;
        
        float y2 = y + (Mathf.PingPong(Time.time * speed, 1) * .75f - .75f);
        
        robot.transform.position = new Vector3(x, y2, z);
        robot.transform.localEulerAngles = new Vector3(angleX, angleY + (Mathf.PingPong(Time.time * 5, rot) * 1 - .1f), angleZ); 
    }
}
