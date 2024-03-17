using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOverMenu : MonoBehaviour
{
    public Text textClock;
    private int level;

    void Start()
    {
        textClock.text = Clock.instance.GetCurrentTimeText().text;

    }

}