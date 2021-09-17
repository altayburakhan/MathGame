using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    public int mainpoint = 10;
    
    public Text text;
    public GameObject a,b,c,d,e;

    private void Start() 
    {
      Text texxt = Instantiate(text, transform.position, transform.rotation) as Text;
    }
   
    /* public void PuanVer() 
     {
      a = GameObject.Find("PointText(Clone)"); 
      Destroy(a);
      mainpoint += 10;
      text.text = mainpoint+"";
      Text texxt = Instantiate(text, transform.position, transform.rotation) as Text;
      texxt.transform.SetParent(GameObject.FindGameObjectWithTag("pirrr").transform, false);
      Destroy(gameObject);
    }*/
    
    public void plusx()
    {
      
       a = GameObject.Find("PointText(Clone)"); 
       b = GameObject.Find("plus(Clone)");
       c = GameObject.Find("minus(Clone)");
       d = GameObject.Find("multi(Clone)");
       e = GameObject.Find("divide(Clone)");
       // To find objects by searching their names.
      Destroy(a);
      // Delete text (for new one).
      mainpoint += 5;
      text.text = mainpoint+"";
        Text texxt = Instantiate(text, new Vector3(0, 537, 0), Quaternion.identity) as Text;
      texxt.transform.SetParent(GameObject.FindGameObjectWithTag("pirrr").transform, false);
      // I created a temporary GameObject and assigned it as a child in Canvas.
      Destroy(b);
      //Delete the item in the slot when the button is pressed.
    }
    public void minusx()
    {
      
      a = GameObject.Find("PointText(Clone)"); 
       b = GameObject.Find("plus(Clone)");
       c = GameObject.Find("minus(Clone)");
       d = GameObject.Find("multi(Clone)");
       e = GameObject.Find("divide(Clone)");
      a = GameObject.Find("PointText(Clone)"); 
      Destroy(a);
      mainpoint -= 5;
      text.text = mainpoint+"";
       Text texxt = Instantiate(text, new Vector3(0, 537, 0), Quaternion.identity) as Text;
      texxt.transform.SetParent(GameObject.FindGameObjectWithTag("pirrr").transform, false);
      Destroy(c);
    }
    public void multix()
    {
      
      a = GameObject.Find("PointText(Clone)"); 
       b = GameObject.Find("plus(Clone)");
       c = GameObject.Find("minus(Clone)");
       d = GameObject.Find("multi(Clone)");
       e = GameObject.Find("divide(Clone)");
      a = GameObject.Find("PointText(Clone)"); 
      Destroy(a);
      mainpoint *= 2;
      text.text = mainpoint+"";
       Text texxt = Instantiate(text, new Vector3(0, 537, 0), Quaternion.identity) as Text;
      texxt.transform.SetParent(GameObject.FindGameObjectWithTag("pirrr").transform, false);
      Destroy(d);
    }
    public void dividex()
    {
      
      a = GameObject.Find("PointText(Clone)"); 
       b = GameObject.Find("plus(Clone)");
       c = GameObject.Find("minus(Clone)");
       d = GameObject.Find("multi(Clone)");
       e = GameObject.Find("divide(Clone)");
       a = GameObject.Find("PointText(Clone)"); 
      Destroy(a);
      mainpoint /= 2;
      text.text = mainpoint+"";
      Text texxt = Instantiate(text, new Vector3(0, 537, 0), Quaternion.identity) as Text;
      texxt.transform.SetParent(GameObject.FindGameObjectWithTag("pirrr").transform, false);
      Destroy(e);
    }
}
