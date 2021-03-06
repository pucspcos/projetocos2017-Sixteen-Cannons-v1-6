﻿using UnityEngine;
using System.Collections;

public class HT_DestroyOnContact : MonoBehaviour
{
    public HT_Score valor;
    public VidaCaixa life;
    int scoreValue = 80;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Tiro")
        {
            //Destroy(other.gameObject);
            Destroy(this.gameObject);
            //life.PerdeVida();
            //valor.ganhar();
            PersistenteData.Score += scoreValue;
            //valor.score++;
            //valor.scoreText.text = "SCORE:\n" + valor.score;
            //valor.UpdateScore();
        }
        if (other.gameObject.tag == "Bomb")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            //valor.perder();
            PersistenteData.Score -= scoreValue;
            //valor.score = valor.score - 2;
            //valor.scoreText.text = "SCORE:\n" + valor.score;
            //valor.UpdateScore();
        }
    }
}
