using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    
    public static GameManager instance;
    EventManager eventManager;

    public float totalScore { get; private set; }
    
    // game over eventi ui managerdeki isgameoveri tetikliyecek bunu solide uygun yap
    //gameover deðiþkeni burda olmalý ama sürekli bunu kontrol edemez uý,, o yüzden orda geçici deðiþken olmalý
    //veya daha iyi bi yöntem bul



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
        
        
        Debug.Log("Score Toplandý : " + value);
        Debug.Log("Toplam Score : " + totalScore);

    }


}
