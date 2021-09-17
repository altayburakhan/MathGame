using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WallBreak : MonoBehaviour
{
    public GameObject txt;
    public int cnt;
    public GameObject ad;
    
    public GameObject gameovertexxt;
    
    void Update()
    {
        cnt = txt.GetComponent<Point>().mainpoint;
        ad = GameObject.Find("PointText(Clone)");
        //gameoverttexxt = GameObject.Find("Image"); 
    }
    
    private void OnTriggerEnter2D(Collider2D wll) 
    {
        if (wll.CompareTag("Player"))
        {
           
           if (cnt >= 40)
            {
              txt.GetComponent<Point>().mainpoint -= 40;
              Destroy(ad);
              Destroy(gameObject);  
            }
            
            if (cnt < 40)
            {
                //gameovertexxt.SetActive(true);
                var img1 = Instantiate(gameovertexxt) as GameObject;
                img1.transform.SetParent(GameObject.FindGameObjectWithTag("pirrr").transform ,false );
                //Time.timeScale = 0;
                
            }
            
        }
    }
}
