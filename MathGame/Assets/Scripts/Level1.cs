using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Level1 : MonoBehaviour
{
    public GameObject buton;
    public GameObject pointintext;
    

    public void Start() 
    {
        buton = GameObject.Find("Button");
        Button btn = buton.GetComponent<Button>(); 
        btn.onClick.AddListener(levelup);
        
    }
    void Update() 
    {  
    }
    void levelup()
    {
        pointintext.GetComponent<Point>().mainpoint = 10;
        SceneManager.LoadScene("Scene1");
        
        Time.timeScale = 1;
    } 
}
