using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;

    private void Start() 
    {
            inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
            //Access to the "Inventory" item in the game object named "Player".
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++)//Checks the occupancy of a slot in the inventory(With "Slot" Script).
            {
                if (inventory.isFull[i] == false)//If it is not full...
                {
                    inventory.isFull[i] = true; //Add an Item to empty slot and assign its value "true"(full).
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
