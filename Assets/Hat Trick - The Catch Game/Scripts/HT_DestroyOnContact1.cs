using UnityEngine;
using System.Collections;

public class HT_DestroyOnContact1 : MonoBehaviour
{
    public HT_Score valor;
    int scoreValue = 80;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Tiro")
        {
            Destroy(other.gameObject);
            //valor.ganhar();
            PersistenteData.Score -= scoreValue;
            //valor.score++;
            //valor.scoreText.text = "SCORE:\n" + valor.score;
            //valor.UpdateScore();
        }
        if (other.gameObject.tag == "Bomb")
        {
            Destroy(other.gameObject);
            //valor.perder();
            //PersistenteData.Score -= scoreValue;
            //valor.score = valor.score - 2;
            //valor.scoreText.text = "SCORE:\n" + valor.score;
            //valor.UpdateScore();
        }
    }
}
