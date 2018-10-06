using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class guessTheNumber : MonoBehaviour {
    public Text InfoText;
    
    private int guessNumber;
    private int count = 0;
    
	// Use this for initialization
	void Start () {
		guessNumber = Random.Range(0,200);
	}
	public void CheckGuess(){
        if(count==0){
            InfoText.text = "Multiple it by 2";
            count=count+1;
        }else if(count==1){
            InfoText.text = "Now Add "+guessNumber+" to Result";
            count=count+1;
        }else if(count==2){
            InfoText.text = "Now divide the Result by 2";
            guessNumber=guessNumber/2;
            count=count+1;
        }else if(count==3){
            InfoText.text = "Now subtract the number You started with from the Result";
            count=count+1;
        }else if(count==4){
            InfoText.text = "The Number U are Left with is "+guessNumber;
            count=count+1;
        }
    }
    public void resetFunction(){
        guessNumber = Random.Range(0,200);
        count=0;
        InfoText.text= "Think of a Number between 0 and 100";
    }
}
