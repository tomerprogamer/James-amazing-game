using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class scoreScript : MonoBehaviour
{
    public TMP_Text scoreText;
    private int scoreCount = 0;

    public void addScore()
    {
        scoreCount += 1;
        scoreText.text = "Pastries: "+ scoreCount.ToString();

        if (SceneManager.GetActiveScene().name == "goodName" && scoreCount >= 15)
        {
            SceneManager.LoadScene("scene1");
        }
    }   

    void Start()
    {
        //addScore();
    }

}
