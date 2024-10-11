using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{
playermove playerm= new playermove();
 public Canvas pauseCanvas;
    private  CustomControls referenceInputs;
    // Start is called before the first frame update
   void Awake()
{
    referenceInputs = new CustomControls();
    referenceInputs.Enable();
}
    private void OnEnable()
{
   referenceInputs.PauseMenu.PasueGame.performed += PauseGame;
  
 
}
private void PauseGame(InputAction.CallbackContext callbackContext){
    Time.timeScale = 0;
    pauseCanvas.gameObject.SetActive(true);
    
    
}
    

    private void OnDisable()
{
      referenceInputs.PauseMenu.PasueGame.performed -= PauseGame;
    referenceInputs.PlayerInput.Disable();
    
    
}
}
