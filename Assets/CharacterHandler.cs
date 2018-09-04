using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHandler : MonoBehaviour {

    float moveSpeed = 20;
    Vector3 velocity;
    Vector3 direction;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        PlayerInput();
        HandleMovement();
	}

    // Gathers player input 
    void PlayerInput () {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");    
    }

    // Handles character movement
    void HandleMovement() {
        direction = Vector3.ClampMagnitude(direction, 1f);
        direction = direction * moveSpeed * Time.deltaTime;

//        transform.position += new Vector3(direction.x * movespeed / 100, 0, direction.z * movespeed / 100);
//        transform.rotation = Quaternion.LookRotation(direction);
    }
}
