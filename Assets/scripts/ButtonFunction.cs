using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonFunction : MonoBehaviour
{

    
 public Canvas pauseCanvas;
    public Slider _slider;
    playermove playerm= new playermove();

    
    // Start is called before the first frame update
  public void ResumeGame()

    {
        
    Time.timeScale = 1;
    pauseCanvas.gameObject.SetActive(false);

    }
    

    public void ExitGame()
    {
        Application.Quit();
    }


}
