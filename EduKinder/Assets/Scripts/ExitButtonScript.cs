
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButtonScript : MonoBehaviour
{
    private Button exiuButton;
    // Start is called before the first frame update
    void Start()
    {
        exiuButton = GetComponent<Button>();
        exiuButton.onClick.AddListener(QuitGame);
    }

    private void QuitGame()
    {
        Application.Quit();
    }
}

