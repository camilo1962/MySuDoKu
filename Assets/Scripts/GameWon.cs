using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameWon : MonoBehaviour
{

    public GameObject WinScreen;
    public Text ClockText;

    void Start()
    {
        WinScreen.SetActive(false);
    }

    private void OnBoardCompleted()
    {
        GameSettings.Instance.SetPaused(true);
        WinScreen.SetActive(true);
        ClockText.text = Clock.instance.GetCurrentTimeText().text;
    }

    private void OnEnable()
    {
        GameEvents.OnBoardCompleted += OnBoardCompleted;
    }

    private void OnDisable()
    {
        GameEvents.OnBoardCompleted -= OnBoardCompleted;
    }

}
