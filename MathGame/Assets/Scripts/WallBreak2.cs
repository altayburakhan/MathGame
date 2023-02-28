using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBreak2 : GameManager
{
    public GameObject txt2;
    public int cnt2;
    public GameObject ad2;
    public GameObject gameovertexxxxt;
    void Update() 
    {
        cnt2 = txt2.GetComponent<Point>().mainpoint;
        ad2 = GameObject.Find("PointText(Clone)");    
    }    

    private void OnTriggerEnter2D(Collider2D wll) 
    {
        if (wll.CompareTag("Player"))
        {
            if (cnt2 >= 55)
            {
                txt2.GetComponent<Point>().mainpoint -= 55;
                Destroy(ad2);
                Destroy(gameObject);
                wallBreakCount++;
            }
            if (cnt2 < 55)
            {
            //gameovertexxxxt.SetActive(true);
            var img3 = Instantiate(gameovertexxxxt) as GameObject;
            img3.transform.SetParent(GameObject.FindGameObjectWithTag("pirrr").transform ,false );
            Time.timeScale = 0;
            }
        }    
        
    }
}
