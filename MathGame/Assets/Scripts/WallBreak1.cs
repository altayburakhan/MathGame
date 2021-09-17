using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallBreak1 : MonoBehaviour
{
    public GameObject txt1;
    public int cnt1;
    public GameObject ad1;

    public GameObject gameovertexxxt;

    void Update() 
    {
        cnt1 = txt1.GetComponent<Point>().mainpoint;
        ad1 = GameObject.Find("PointText(Clone)");    
    }    

    private void OnTriggerEnter2D(Collider2D wll) 
    {
        if (wll.CompareTag("Player"))
        {
            if (cnt1 >= 22)
            {
                txt1.GetComponent<Point>().mainpoint -= 22;
                Destroy(ad1);
                Destroy(gameObject); 
            }
             if (cnt1 < 22)
            {
            //gameovertexxxt.SetActive(true);
            var img2 = Instantiate(gameovertexxxt) as GameObject;
            img2.transform.SetParent(GameObject.FindGameObjectWithTag("pirrr").transform ,false );
            Time.timeScale = 0;
            }
        }    
       
    }
}
