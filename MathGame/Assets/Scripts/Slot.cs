using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    private Inventory inventory;
    public int i;
    private void Start() 
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>(); 
        
    }
    private void Update() {
        {
            if (transform.childCount <= 0)
            {
                inventory.isFull[i] = false;
            }
           //Indicates the fullness of the slot in the inventory.
        }
    }
   public void DropItem()
   {
       foreach (Transform child in transform)//For dropping items.
       {
           GameObject.Destroy(child.gameObject);
       }
   }
}
