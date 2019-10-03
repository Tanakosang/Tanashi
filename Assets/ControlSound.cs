using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlSound : MonoBehaviour
{
    public AudioSource asound;
    public Slider sd;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void Con_sound()
    {
        asound.volume = sd.value;
    }
}
