using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public float TimerValue = 90;
    public TMP_Text timertext;
    public bool pause;
   public GameObject losecanves;
    public List<GameObject> Itemlist;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        if (pause == false)
        {


            if (TimerValue > 0)
            {
                TimerValue -= Time.deltaTime;
            }
            else
            {
                TimerValue = 0;
                losecanves.SetActive(true);
            }
            DesplayTime(TimerValue);
        }
    }

    void DesplayTime(float timeToDesplay)
    {
        if (timeToDesplay < 0)
        {
            timeToDesplay = 0;
        }
        float minutes = Mathf.FloorToInt(timeToDesplay / 60);
        float seconds = Mathf.FloorToInt(timeToDesplay % 60);
        float milliseconds = timeToDesplay % 1 * 1000;

        timertext.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }
    public void Testing() 
    { Debug.Log("teetter"); }
}
