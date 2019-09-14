using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_controller : MonoBehaviour
{
  public float speed = 10.0F;
  bool jumpDebounce = false; 

  // Start is called before the first frame update
  void Start(){
    Cursor.lockState = CursorLockMode.Locked;
  }
  // Update is called once per frame
  void Update(){
  	bool jump = Input.GetButtonDown("Jump");
  	float up = 0.0f;
  	if(jump && !jumpDebounce){
  		up = 1.0f * speed;
  	}
  	jumpDebounce = jump;
  	float translation = Input.GetAxis("Vertical") * speed;
  	float strafe = Input.GetAxis("Horizontal") * speed;
	
  	translation *= Time.deltaTime;
  	strafe *= Time.deltaTime;
  	transform.Translate(strafe, up, translation);
	
  	if (Input.GetKeyDown("escape")){
  	  Cursor.lockState=CursorLockMode.None;
  	}
       
   }
}
