using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonFunction : MonoBehaviour
{

    
public Canvas pauseCanvas;  
 
    public void ResumeGame()
        {
        //despausa el juego        
        Time.timeScale = 1;
        pauseCanvas.gameObject.SetActive(false);
        } 
    public void ExitGame()
        {
            Application.Quit();
        }


}
