using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    int score = 0;
    public TMP_Text scoreText;
    public TMP_Text loseScoreText;
    float scorePlusCd = 1;

    private void Update()
    {
        scorePlusCd -= Time.deltaTime;
        loseScoreText.text = "¬аш счет: " + score.ToString();
        if(scorePlusCd <= 0 )
        {
            scorePlusCd = 1;
            score++;
            scoreText.text = score.ToString();

        }
    }
}
