using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btn : GameManager
{

    // funkcja animuje przycisk oraz przechodzi do sceny która nazywa się tak jak przycisk (np. Btn_Main = Main)

    public void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(Btn_touch);
    }
    public void Btn_touch()
    {
        int length = this.name.Length;
        GetComponent<Animation>().Play("Btn_bounce");
        StartCoroutine(LoadScene(1.2f, this.name.Substring(4, length - 4)));
    }
}
