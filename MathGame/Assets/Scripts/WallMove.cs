using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{
  public float speed;
  void Start() 
    {
        
        Destroy(gameObject,25);
        
    }
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;    
    }
}
