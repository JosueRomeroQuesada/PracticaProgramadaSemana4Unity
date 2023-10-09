using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    [SerializeField]
    TextMeshProUGUI nameText;

    [SerializeField]
    TextMeshProUGUI moneyText;
    void Awake()
    {
        nameText.text = StateManager.Instance.getName();
        moneyText.text = StateManager.Instance.getPrize().ToString();
    }

    private void Start()
    {
        
    }

    public void Back()
    {
        
        LevelManager.Instance.FirstScene();
    }

}


