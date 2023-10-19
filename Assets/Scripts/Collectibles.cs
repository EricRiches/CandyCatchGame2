using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectibles : MonoBehaviour
{
    public string nameCollectible;

    public int score;

    

    public Collectibles(string name, int scoreValue, int restoreHPvalue)
    {
        this.nameCollectible = name;
        this.score = score = scoreValue;
        
    }

    public void UpdateScore(int score1)
    {
        ScoreManager.scoreManager.UpdateScore(score1);
    }

    

   
}
