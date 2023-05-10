using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    
    public static GameManager instance;
    EventManager eventManager;

    public float totalScore { get; private set; }
    
    // game over eventi ui managerdeki isgameoveri tetikliyecek bunu solide uygun yap
    //gameover de�i�keni burda olmal� ama s�rekli bunu kontrol edemez u�,, o y�zden orda ge�ici de�i�ken olmal�
    //veya daha iyi bi y�ntem bul



    private void Awake()
    {
        instance = this;
        eventManager = EventManager.instance;
        totalScore = 0;
    }

    private void Start()
    {
        Cursor.visible = false;

    }

    public void DecreaseScore()
    {
        totalScore -= 10;
    }

    public void AddScore(int value)
    {
        totalScore += value;
        
        
        Debug.Log("Score Topland� : " + value);
        Debug.Log("Toplam Score : " + totalScore);

    }


}
