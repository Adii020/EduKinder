using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bear : MonoBehaviour
{
    public GameObject bear;
    // Start is called before the first frame update
    void Start()
    {
        bear = GameObject.Find("Icon_BgBear/Icon_Bear");
       
    }
    public void PlayILoveYou()
    {
        Debug.Log("I Love you");
        bear.GetComponent<AudioSource>().Play();
       
    }
   
}
