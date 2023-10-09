using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WelcomeController : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI textbox;

    public void Play() 
    {
        StateManager.Instance.setName(textbox.text);
        LevelManager.Instance.NextScene();
    }
    public void Back()
    {
        //StateManager.Instance.setName(textbox.text);
        LevelManager.Instance.FirstScene();
    }
    public void state()
    {
        
        LevelManager.Instance.FirstScene();
    }
    void Start()
    {
        AudioManager.Instance.PlayMusic("Theme");
        
    }
}
