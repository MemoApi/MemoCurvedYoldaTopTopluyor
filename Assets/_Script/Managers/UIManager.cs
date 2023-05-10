using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{

    [Range(0,100)] [SerializeField] float timerValue;
    [SerializeField] float decreaseRate = .5f;
    
    [SerializeField] bool valueChange;
    float nextValue;
    
    [SerializeField] float lerpValue;

    public Slider timerSlider;
    public TMP_Text totalScoreText;
    public TMP_Text AddedScoreText;

    //sliderýn zamanla düþüyor, collission olunca lerplenerek artýyor, lerp sýrasýnda azalma duruyor sonra baþlýyor

    

    private void Start()
    {
        valueChange = false;
        timerValue = 100;
        totalScoreText.text = "0";
        
    }

    private void Update()
    {
        if(timerValue>0 && !valueChange)
        {
            timerValue -= Time.deltaTime * decreaseRate;
            timerSlider.value = timerValue / 100;
        }             
        if(valueChange)
        {
            timerValue = Mathf.Lerp(timerValue, nextValue, lerpValue);
            timerSlider.value = timerValue / 100;

            if (Mathf.Abs(timerValue-nextValue)<0.1f)
            {
                Debug.Log("Lerp Tamamlandý");
                valueChange = false;

            }

        }

        if(timerValue<=0)
        {
            //GAME OVER
            
            Debug.Log("Kalan süre kontrol : \nTimer Value : " + timerValue + "\nSlider Value : " + timerSlider.value);
            Time.timeScale = 0;
        }

        
    }


    public void DecreaseSlider()
    {
        nextValue = timerValue - 10;
        nextValue = Mathf.Clamp(nextValue, 0, 100);
        valueChange = true;

    }

    public void IncreaseSlider(int value)
    {

        nextValue = timerValue + value;
        nextValue = Mathf.Clamp(nextValue, 0, 100);
        
        valueChange = true;

        Debug.Log("Toplam Time Deðeri : " + nextValue);
        
    }

    public void ShowAddedScore(int value)
    {
        if (value > 0) AddedScoreText.text = "+"+value;
        else AddedScoreText.text = value.ToString();
        StartCoroutine("ScoreAnim");
    }

    IEnumerator ScoreAnim()
    {
        AddedScoreText.gameObject.SetActive(true);
        yield return new WaitForSeconds(.5f);
        AddedScoreText.gameObject.SetActive(false);
    }


    public void UpdateScoreText()
    {
        totalScoreText.text = GameManager.instance.totalScore.ToString();
    }

}
