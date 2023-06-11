using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="state")]
public class state : ScriptableObject
{
    [TextArea(10,14)] [SerializeField] string storyText;
    [SerializeField] string choiceOne, choiceTwo, choisThree, choiseFour;
    [SerializeField] state[] nextStates;
    [SerializeField] int pieceNumber = 0;
    [SerializeField] bool isDeath = false;
    [SerializeField] bool lastFight = false;
    [SerializeField] int mapIconHolder=0;
    [SerializeField] bool isShrine = false;
    [SerializeField] int deathNumb = 0;

    public int GetDeathNum()
    {
        return deathNumb;
    }
    public bool GetIsShrine()
    {
        return isShrine;
    }
    public int GetMapIcon()
    {
        return mapIconHolder;
    }
    public bool GetDeath()
    {
        return isDeath;
    }
    public string GetStateStory()
    {
        return storyText;
    }
    public state[] GetNextStates() 
    {
        return nextStates;
    }
    public int GetPieceNumber()
    {
        return pieceNumber;
    }
    public bool GetLastFight()
    {
        return lastFight;
    }
    public string GetFirstChoice()
    {
        return choiceOne;
    }
    public string GetSecondChoice()
    {
        return choiceTwo;
    }
    public string GetThirdChoice()
    {
        return choisThree;
    }
    public string GetFourthChoice()
    {
        return choiseFour;
    }
}
