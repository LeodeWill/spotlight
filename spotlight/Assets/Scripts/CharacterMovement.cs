using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    public float moveSpeed;
    Rigidbody2D body;

    private void Awake() {
        body = this.GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void Move(Vector3 direction){
        if (body == null){
            Debug.Log("Rigidbody not found on " + name);
            return;
        }

        body.velocity = direction.normalized * moveSpeed;
    }

    public void Stop(){
        body.velocity = Vector3.zero;
    }
}
