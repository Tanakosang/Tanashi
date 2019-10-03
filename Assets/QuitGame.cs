using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        Quit();
    }

    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;  
    }
    void Update()
    {

    }
}
