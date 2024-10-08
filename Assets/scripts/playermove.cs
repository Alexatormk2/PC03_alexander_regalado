using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using JetBrains.Annotations;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Slider = UnityEngine.UI.Slider;
using Vector2 = UnityEngine.Vector2;

public class playermove : MonoBehaviour
{
        private Vector2 keyDetect;
        
    public  int jumpForce = 4;
    public float speed =0.05f;

    public Rigidbody player;
   private  CustomControls referenceInputs;



  



public void SetSliderSpeed(float slspeed){
    speed = slspeed;


}
void Awake()
{



    referenceInputs = new CustomControls();
    referenceInputs.Enable();
   
 
   

}
private void MovStart(InputAction.CallbackContext callbackContext)
{
    CancelInvoke(nameof(MoveOn));
    InvokeRepeating( nameof(MoveOn),0,0.01f);
    keyDetect= callbackContext.ReadValue<UnityEngine.Vector2> ();
}


private void MoveOn(){

    Debug.Log("tecla: " + keyDetect);



player.transform.position+= new UnityEngine.Vector3(keyDetect.x*speed,0f,keyDetect.y*speed);
    

}
private void MoveStop(InputAction.CallbackContext callbackContext)
{
CancelInvoke(nameof(MoveOn));
}


private void OnEnable()
{
   referenceInputs.PlayerInput.jump.performed +=jump;
   referenceInputs.PlayerInput.move.performed +=MovStart;
   referenceInputs.PlayerInput.move.canceled +=MoveStop;
 
}
private void OnDisable()
{
    referenceInputs.PlayerInput.jump.performed -=jump;
    referenceInputs.PlayerInput.move.performed -=MovStart;
    referenceInputs.PlayerInput.move.canceled -=MoveStop;
    referenceInputs.PlayerInput.Disable();
    
    
}

void FixedUpdate()
{


}



private void jump(InputAction.CallbackContext callbackContext)
{
    


 
       player.AddForce(UnityEngine.Vector3.up * jumpForce,ForceMode.Impulse);
    

        
    
}


}
