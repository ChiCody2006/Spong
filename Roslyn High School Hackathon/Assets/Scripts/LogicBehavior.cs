using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LogicBehavior : MonoBehaviour
{
    [SerializeField] GameObject ball;
    private int player1Score = 0;
    private int player2Score = 0;
    public bool scored = false;
    public bool finish = false;
    [SerializeField] TMP_Text score1;
    [SerializeField] TMP_Text score2;
    [SerializeField] GameObject GameOver;
    [SerializeField] TMP_Text whoWon;
    private BallBehavior ballB;
    
    // Start is called before the first frame update
    void Start()
    {
        ballB = GameObject.FindGameObjectWithTag("Ball").GetComponent<BallBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ball.transform.position.x>9f)
        {
            score(1, 1);
            scored = true;
        } 
        if(ball.transform.position.x<-9f)
        {
            score(2, 1);
            scored = true;
        }
        if(player1Score>=10)
        {
            gameOver(1);
            finish = true;
        } 
        if(player2Score>=10)
        {
            gameOver(2);
            finish = true;
        }
    }

    private void score(int player, int addToScore)
    {
        if(player==1)
        {
            player1Score += addToScore;
            score1.SetText("Player 1 Score: "+player1Score.ToString());
        } else if(player==2)
        {
            player2Score += addToScore;
            score2.SetText("Player 2 Score: " + player2Score.ToString());
        }
        ball.transform.position = new Vector3(0, 0, 0);
        ballB.setDir();
    }

    private void gameOver(int player)
    {
        GameOver.SetActive(true);
        whoWon.SetText("Player " + player + " Won!");
        
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
