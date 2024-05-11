using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    int score = 0;
    public TMP_Text scoreText;
    float scorePlusCd = 1;

    private void Update()
    {
        scorePlusCd -= Time.deltaTime;
        if(scorePlusCd <= 0 )
        {
            scorePlusCd = 1;
            score++;
            scoreText.text = score.ToString();
        }
    }
}
