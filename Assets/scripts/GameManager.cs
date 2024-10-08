using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{

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

    SceneManager.LoadScene("PAUSEMENU",LoadSceneMode.Additive);
    Time.timeScale = 0;
}
    

    private void OnDisable()
{
      referenceInputs.PauseMenu.PasueGame.performed -= PauseGame;
    referenceInputs.PlayerInput.Disable();
    
    
}
}
