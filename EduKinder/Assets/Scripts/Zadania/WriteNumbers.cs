using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WriteNumbers : SelectNumber
{
    GameObject number;
    GameObject startpoint;
    // Start is called before the first frame update
    void Start()
    {     
        NumberToLoad();
        startpoint = GameObject.Find("StartPoint");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Input.mousePosition;
        pos.z = 0;
        startpoint.GetComponent<Animation>().Play("Btn_Attention");
        if (Input.GetMouseButtonDown(0))
        {
            //number.transform.position = pos;
            Drawing();

        }

    }
   
    //Funkcja aktywuje numer który na się pojawić na scenie zmienia również tytuł na pasku
    private void NumberToLoad()
    {
        SetTitle(PlayerPrefs.GetString("number"));
        number =  GameObject.Find("Panel/WorkPlace/" + PlayerPrefs.GetString("number"));
        number.active = true;
        Invoke("Write"+ PlayerPrefs.GetString("number"), 0f);  
    }


    //Funkcja rysowania
    private void Drawing()
    {
        
    }



    private void Write0()
    {
        Debug.Log("Napisz 0");
    }
    private void Write1()
    {
        Debug.Log("Napisz 1");
    }
    private void Write2()
    {
        Debug.Log("Napisz 2");
    }
    private void Write3()
    {
        Debug.Log("Napisz 3");
    }
    private void Write4()
    {
        Debug.Log("Napisz 4");
    }
    private void Write5()
    {
        Debug.Log("Napisz 5");
    }
    private void Write6()
    {
        Debug.Log("Napisz 6");
    }
    private void Write7()
    {
        Debug.Log("Napisz 7");
    }
    private void Write8()
    {
        Debug.Log("Napisz 8");
    }
    private void Write9()
    {
        Debug.Log("Napisz 9");
    }



	

}
