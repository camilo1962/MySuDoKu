using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameModeText : MonoBehaviour
{
    private Text gameModeText;

    private void Awake()
    {
        gameModeText = GetComponent<Text>();
    }

    void Start()
    {
        gameModeText.text = GameSettings.Instance.GetGameMode();
    }

}
