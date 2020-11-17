using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintMaker 
{
    public static string generateHint(int number, int guess){

        int random = Random.Range(0,10);

        if (random > 8 ){
            // Select a random number bigger than 
            int greaterValue = number + Random.Range(0, 20);
            if (greaterValue >= 100) {
                return "I give no hint for you this time";
            } else {
                return "Your number is lesser than " + greaterValue;
            }
        } else if (random > 6 && random  <= 8 ){
            // Select a random number bigger than 
            int lesserValue = number - Random.Range(0, 20);
            if (lesserValue <= 0) {
                return "I give no hint for you this time";
            } else {
                return "Your number is greater than " + lesserValue;
            }
        } else if (random > 5 && random  <= 6 ){
            // Select a random number bigger than 
            if (number % 2 == 0){
                return "Your number is an even number";
            } else {
                return "Your number is an odd number";
            }
        } else if (random > 4 && random  <= 5 ){
            // Select a random number bigger than 
            if (number % 3 == 0){
                return "Your number can be divisible by 3";
            } else {
                return "Your number cannot be divisible by 3";
            }
        } else if (random > 3 && random  <= 4 ){
            // Select a random number bigger than 
            if (number > 50){
                return "Your number is greater than 50";
            } else {
                return "Your number is not greater than 50";
            }
        } else if (random >= 0 && random  <= 3 ) {
            int distance = Mathf.Abs(guess - number) ;
            Debug.Log(distance);
            if (distance<= 20 && distance > 10){
                return "Try more, your number is closer to the one I picked";
            } else if (distance <= 10 && distance > 5){
                return "Yes, you are very close, try harder";
            } else if (distance <= 5 && distance > 2){
                return "YES YES YES! Very close. ";
            } else if (distance <= 2){
                return "YES YES YES YES YES! Just a little bit MORE and you WIN! ";
            } else {
                return "Your guess is far away from my number";
            }
        }
        return "Try next time! No hint for you. A ha ha.";
    }


    public static bool chkprime(int num)
    {
        for (int i=2; i < num; i++)
          if (num %i == 0) 
            return false;
        return true;
    }
    
}
