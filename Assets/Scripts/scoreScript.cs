using UnityEngine;
using TMPro;
public class scoreScript : MonoBehaviour
{
    public TMP_Text scoreText;
    private int scoreCount = 0;

    public void addScore()
    {
        scoreCount += 1;
        scoreText.text = "Pastries: "+ scoreCount.ToString();
    }

    void Start()
    {
        //addScore();
    }

}
