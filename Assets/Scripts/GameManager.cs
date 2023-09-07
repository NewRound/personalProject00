using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public GameObject Player;
    public GameObject DoingCanvas;
    public GameObject StartCanvas;
    public Text Name;
    public Text NameInput;


    private void Awake()
    {
        instance = this;
    }


    public void PressJoinButton()
    {
        DoingCanvas.SetActive(true);
        StartCanvas.SetActive(false);
        NameInput.text = Name.text;
    }

}
