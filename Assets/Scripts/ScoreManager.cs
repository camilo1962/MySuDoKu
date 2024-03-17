using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

   

    private int oldHighScore = 0;
    

    
    public Text  highScoreText;





    private void UpdateHighScore(int clock)
    {
        int oldHighScore = PlayerPrefs.GetInt("Record");
        if (clock < oldHighScore)
        {
            PlayerPrefs.SetInt("Record", clock);
            PlayerPrefs.Save();
            highScoreText.text = oldHighScore.ToString();
        }
    }

   

    public void ClearHigsScore()
    {
        PlayerPrefs.DeleteKey("Record");
        oldHighScore = 0;
        highScoreText.text = oldHighScore.ToString();
    }
}
