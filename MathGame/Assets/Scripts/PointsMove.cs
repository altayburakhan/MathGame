using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PointsMove : MonoBehaviour
{
    public float speed;
    

    void Start() 
    {
        
        Destroy(gameObject,7);
        //Delete the falling item after 12 seconds.
       
    }
    
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;    
    }
    
}
