using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    private GeneralManagement generalManager;
    public TMP_Text ScoreText;
    private int Score=0;
    

    private void Start()
    {
        generalManager = FindObjectOfType<GeneralManagement>();              

    }

    public void OnClickButton() 
    {
        if (generalManager.durum == true)
        {
            Score++;
            ScoreText.text = Score.ToString();
            generalManager.ChangeColor();
            StartCoroutine(WaitingTime());                
        }        
    }

    public IEnumerator WaitingTime()
    {
        yield return new WaitForSeconds(0.5f);
        generalManager.durum = false;
    }

}
