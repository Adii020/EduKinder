using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   
    // Start is called before the first frame update
  
    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        
    }
    

    public IEnumerator LoadScene(float t, string sceneName)
    {
         
        yield return new WaitForSeconds(t);
        SceneManager.LoadScene(sceneName);
       
    }

    public void BackScene()
    {
        SceneManager.LoadScene("Main"); 
    }

    public void CloudText(string cloudText)
    {
        GameObject.Find("Cloud/Text").GetComponent<Text>().text = cloudText;
    }
    
    public void SetTitle(string title)
    {
        GameObject.Find("Title/Text").GetComponent<Text>().text = title;
    }
}
 
