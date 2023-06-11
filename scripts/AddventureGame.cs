using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] Text choice1, choice2, choice3, choice4;
    [SerializeField] state StartingState;
    [SerializeField] GameObject[] mapIcons;
    [SerializeField] Sprite[] backgrounds;
    [SerializeField] GameObject[] losescreens;
    [SerializeField] Image background;

    [SerializeField] GameObject firstCanvas;
    [SerializeField] GameObject secondCanvas;
    [SerializeField] GameObject thirdCanvas;
    [SerializeField] GameObject forthCanvas;
    [SerializeField] GameObject victoryCanvas;
    [SerializeField] GameObject losingCanvas;
    [SerializeField] GameObject blackSmithCanvas;
    [SerializeField] GameObject b1, b2, b3, b4;
    

    state state;
    bool did = true;
    
    // Start is called before the first frame update
    void Start()
    {
        state = StartingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
       // ManageState();
        LockingForPiece();
        Death();
        LastFight();
        ButtonControler();
        MapIconControler();
        BlackSmithCanvas();
        ChoiceTextController();

    }

    private void ChoiceTextController()
    {
        choice1.text = state.GetFirstChoice();
        choice2.text = state.GetSecondChoice();
        choice3.text = state.GetThirdChoice();
        choice4.text = state.GetFourthChoice();
    }

    private void BlackSmithCanvas()
    {
       var numOfpeices= FindObjectOfType<Level>().GetNumOfPiece();
        var shrine = state.GetIsShrine();
        var blackSmith = FindObjectOfType<Level>().GetBlackSmith();
        if (numOfpeices == 4 && shrine && blackSmith) 
        {
            blackSmithCanvas.SetActive(true);
        }
    }
    public void MapIconControler()
    {
        int iconNumber = state.GetMapIcon();
 
        for (int i = 0; i < mapIcons.Length; i++)
        {
            if (i == iconNumber)
            {
                mapIcons[i].SetActive(true);
                background.sprite = backgrounds[i];
                //backgrounds[i].SetActive(true);
            }
            else
            {
                mapIcons[i].SetActive(false);
  
             
               //backgrounds[i].SetActive(false);
            }
        }
    }
    private void Death()
    {
        bool death = state.GetDeath();
        
        if (death)
        {
            int loseScrennNum = state.GetDeathNum();
            for (int i = 0; i < losescreens.Length ; i++)
            {
                if (loseScrennNum == i&&did)
                {
                    Instantiate(losescreens[i], new Vector3(0, 0, 0), Quaternion.identity);
                    did = false;
                }
            }

        }
    }

    private void ButtonControler()
    {
        var nextStates = state.GetNextStates();
        if (nextStates.Length >= 1) 
        {
            b1.SetActive(true);
        }
        else
        {
            b1.SetActive(false);
        }
        if (nextStates.Length >= 2) 
        {
            b2.SetActive(true);
        }
        else
        {
            b2.SetActive(false);
        }
        if (nextStates.Length >= 3) 
        {
            b3.SetActive(true);
        }
        else
        {
            b3.SetActive(false);
        }
        if (nextStates.Length >= 4) 
        {
            b4.SetActive(true);
        }
        else
        {
            b4.SetActive(false);
        }
    }

    private void LockingForPiece()
    {
        int pieceNumber = state.GetPieceNumber();
        if (pieceNumber == 1 && firstCanvas != null)
        {
            firstCanvas.SetActive(true);
        }
        else if (pieceNumber == 2 && secondCanvas != null)
        {
            secondCanvas.SetActive(true);
        }
        else if (pieceNumber == 3 && thirdCanvas != null)
        {
            thirdCanvas.SetActive(true);
        }
        else if (pieceNumber == 4 && forthCanvas != null) 
        {
            forthCanvas.SetActive(true);
        }
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();
        for(int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextStates[index];
            }
        }

        textComponent.text = state.GetStateStory();
    }
    public void ButtonOne()
    {
        var nextState = state.GetNextStates();
        if (nextState[0] != null)
        {
            state = nextState[0];
            textComponent.text = state.GetStateStory();
        }
    }
    public void ButtonTwo()
    {
        var nextState = state.GetNextStates();
        if (nextState[1] != null)
        {
            state = nextState[1];
            textComponent.text = state.GetStateStory();
        }
    }
    public void ButtonThree()
    {
        var nextState = state.GetNextStates();
        if (nextState[2] != null)
        {
            state = nextState[2];
            textComponent.text = state.GetStateStory();
        }
    }
    public void ButtonFour()
    {
        var nextState = state.GetNextStates();
        if (nextState[3] != null)
        {
            state = nextState[3];
            textComponent.text = state.GetStateStory();
        }
    }
    
    private void LastFight()
    {
        int numOfPieces = FindObjectOfType<Level>().GetNumOfPiece();
        if (state.GetLastFight())
        {
            if (numOfPieces == 4)
            {
                victoryCanvas.SetActive(true);
            }
            else
            {
                losingCanvas.SetActive(true);
            }
        }
    }
}
