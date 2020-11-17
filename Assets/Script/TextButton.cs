using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextButton : MonoBehaviour
{

    private string[] sentences = {
        "Hello everyone, i am Merline, your friendly wizard. Want to join a game?",
        "The rule is simple. You just guess a number from 0 - 100. Guess it correct and you win",
        "Every time you guess it incorrect, i give you a hint. Is that ok?"
    };
    [SerializeField]
    public TextMeshProUGUI merlineTalks;
    private int merlinTalkOrder = 0;
    // Start is called before the first frame update
    private void Awake() {
        merlineTalks.text = sentences[merlinTalkOrder];
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextSentence(){
        merlinTalkOrder += 1;
        if (merlinTalkOrder > sentences.Length - 1) { SceneChanger.ChangeScene("MainGame");}
        merlineTalks.text = sentences[merlinTalkOrder];
    }

    
}
