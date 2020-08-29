using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

    CharacterMovement movement;
    Thief stealth;

    public float axisDeadZone = 0.2f;

    private void Awake() {
        movement = this.GetComponent<CharacterMovement>();
        stealth = this.GetComponent<Thief>();
    }

    private void Update() {
        Vector3 direction = Vector3.zero;
        float hor = Input.GetAxisRaw("Horizontal"), vert = Input.GetAxisRaw("Vertical");
        if (Mathf.Abs(hor) >= axisDeadZone) direction += Vector3.right * hor;
        if (Mathf.Abs(vert) >= axisDeadZone) direction += Vector3.up * vert;
        
        if(direction.magnitude > 0f){
            movement.Move(direction);
        }else{
            movement.Stop();
        }

        if(Input.GetKeyDown(KeyCode.E)){
            stealth.SwitchHide();
            Debug.Log("*Hidden*");
        }
    }
}
