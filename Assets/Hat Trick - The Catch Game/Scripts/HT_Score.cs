using UnityEngine;
using System.Collections;

public class HT_Score : MonoBehaviour
{

    public GUIText scoreText;
    public int ballValue;


    void Update()
    {
        //UpdateScore();
        scoreText.text = "SCORE:\n" + PersistenteData.Score;
        //scoreText.text = "Score: " + PersistenteData.Score;
    }

    //public void ganhar()
    //{
    //    score++;
    //    UpdateScore();

    //}
    //public void perder()
    //{
    //    score = score - 2;
    //    UpdateScore();
    //}

    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    score += ballValue;
    //    UpdateScore();
    //}

    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //if (collision.gameObject.tag == "Bomb")
    //{
    //    score = score - 2;
    //    UpdateScore();
    //}
    //}

    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.gameObject.tag == "Tiro")
    //    {
    //        score = score + 1;
    //        UpdateScore();
    //    }
    //    if (other.gameObject.tag == "Bomb")
    //    {
    //        score = score - 2;
    //        UpdateScore();
    //    }
    //}

    //public void UpdateScore()
    //{
    //    scoreText.text = "SCORE:\n" + score;
    //}
}
