using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = {"coach", "wagon", "honor", "trunk", "crash", "lunch", "stuff", "evoke", "quota", "woman", "court", "float", "draft", "punch", "paint", "touch", "table", "anger", "range", "wheat", "cycle", "stake", "moral", "brick", "seize", "spite", "north", "doors", "south", "valid", "youth", "strap", "steep", "grand", "laser", "habit", "creep", "grind", "river", "alive", "groan", "panel", "widen", "nerve", "water", "yearn", "colon", "thumb", "fresh", "heavy"};

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
