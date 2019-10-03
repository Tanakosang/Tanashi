using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Choose6 : MonoBehaviour
{
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        SceneManager.LoadScene("7");
    }

    void Update()
    {

    }
}