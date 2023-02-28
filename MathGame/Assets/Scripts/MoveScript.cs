using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveScript : MonoBehaviour
{
    
    public float speed;
    private float x;
    Rigidbody2D body;
    
    void Start() 
    {
        body = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        
    }
    /*void FixedUpdate() 
    {
        body.velocity = new Vector2(x * speed,0);
    }*/
    public void right()
    {
         
           transform.Translate(Vector2.right * 1.7f);
       
    }
    public void left()
    {
        
           transform.Translate(Vector2.left * 1.7f );
       
    }
    
        
         
    

}
