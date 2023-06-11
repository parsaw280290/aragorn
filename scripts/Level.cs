using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] GameObject firstCanvas;
    [SerializeField] GameObject secondCanvas;
    [SerializeField] GameObject thirdCanvas;
    [SerializeField] GameObject forthCanvas;
    [SerializeField] GameObject blacksmithCnavas;
    [SerializeField] GameObject pieceOneImage, pieceTwoImg, pieceThreeImage, pieceFourImg;
    bool blackSmith = true;
    int numOfPieces = 0;
    


    public void Kil1()
    {
        numOfPieces++;
        Destroy(firstCanvas);
        pieceOneImage.SetActive(true);
        print(numOfPieces);
    }
    public void Kil2()
    {
        numOfPieces++;
        Destroy(secondCanvas);
        pieceTwoImg.SetActive(true);
        print(numOfPieces);
    }
    public void Kil3()
    {
        numOfPieces++;
        Destroy(thirdCanvas);
        pieceThreeImage.SetActive(true);
        print(numOfPieces);
    }
    public void Kil4()
    {
        numOfPieces++;
        Destroy(forthCanvas);
        pieceOneImage.SetActive(false);
        pieceTwoImg.SetActive(false);
        pieceThreeImage.SetActive(false);
        pieceFourImg.SetActive(true);
        print(numOfPieces);
    }
    public void KillBlacksmithCanvas()
    {
        blacksmithCnavas.SetActive(false);
        blackSmith = false;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public int GetNumOfPiece()
    {
        return numOfPieces;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public bool GetBlackSmith()
    {
        return blackSmith;
    }
}
