using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBreak3 : MonoBehaviour
{
     public GameObject txt3;
    public int cnt3;
    public GameObject ad3;
    public GameObject gameoverr;

    void Update() 
    {
        cnt3 = txt3.GetComponent<Point>().mainpoint;
        ad3 = GameObject.Find("PointText(Clone)");    
    }    

    private void OnTriggerEnter2D(Collider2D wll) 
    {
        if (wll.CompareTag("Player"))
        {
            if (cnt3 >= 60)
            {
                txt3.GetComponent<Point>().mainpoint -= 60;
                Destroy(ad3);
                Destroy(gameObject); 
            }
            if (cnt3 < 60)
            {
            //gameoverr.SetActive(true);
            var img4 = Instantiate(gameoverr) as GameObject;
            img4.transform.SetParent(GameObject.FindGameObjectWithTag("pirrr").transform ,false );
            Time.timeScale = 0;
            }
        }    
        
    }
}
