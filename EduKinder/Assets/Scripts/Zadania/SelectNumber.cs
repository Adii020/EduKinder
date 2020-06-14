using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectNumber : GameManager
{
    GameObject workPlace;
    // Start is called before the first frame update
    void Start()
    {
        workPlace = GameObject.Find("WorkPlace");
        AddListenerNumberButton();
   
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Dodanie Listenera do przycisków z numerami. Numer powinien być 7 znakiem nazwy przycisku np. Btn_Num4
    private void AddListenerNumberButton()
    {
     
        for (int i = 0; i < workPlace.transform.childCount; i++)
        {
            string btn_number = workPlace.transform.GetChild(i).name;
            workPlace.transform.GetChild(i).GetComponent<Button>().onClick.AddListener(() => LoadNumber(btn_number));
        }
    }
   private void LoadNumber(string number)
    {
        GameObject btn_number = GameObject.Find(number);
        number = number.Substring(7, number.Length - 7);
        btn_number.GetComponent<Animation>().Play("Btn_bounce");
       // Debug.Log(number.Substring(7, number.Length - 7));
        StartCoroutine(LoadScene(1.2f, "WriteNumbers"));
        PlayerPrefs.SetString("number", number);
        //GameObject.Find("Title/Text").GetComponent<Text>().text = number;

        //Debug.Log(PlayerPrefs.GetString("number"));
        // GetComponent<Animation>().Play("Btn_bounce");
    }
    
}
