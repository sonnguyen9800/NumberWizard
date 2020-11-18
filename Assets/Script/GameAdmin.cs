using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
public class GameAdmin : MonoBehaviour
{

    public int numberCorrect = 100;
    public int GuessTime = 0;
    public int guessNumber = 0;

    [SerializeField] TextMeshProUGUI guessTimeIndicator;
    [SerializeField]
    private TextMeshProUGUI merlinTalks;
    [SerializeField]
    private TMP_InputField textInputField;
    private void Awake() {
        // Initilize a random number first
        numberCorrect = UnityEngine.Random.Range(0,100);
        
            // guessTimeIndicator.text = "Guess Time: 0";
    }


    public void takeGuessNumber(TMP_InputField number){
        if (number.text == null) return;
        try {
            //Debug.Log(number.text);
            this.guessNumber = int.Parse(number.text);
        } catch (Exception e){
            Debug.LogError("Handle error" + e);
        }
   
    }

    public void makeGuess(){
        GuessTime += 1;
        guessTimeIndicator.text = "Guess Time: " + GuessTime;
        if (this.guessNumber == this.numberCorrect){
            WinAnnoucement();
        } else {
            updateHint(this.numberCorrect);
        }
    }

    public void updateHint(int number){
        this.merlinTalks.text = HintMaker.generateHint(number, guessNumber);
    }

    public void WinAnnoucement(){
        // Move to next sceen
        SceneChanger.ChangeScene("Victory");
    }
}
