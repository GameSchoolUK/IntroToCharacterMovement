using UnityEngine;
using System.Collections;

public class playermovement : MonoBehaviour {

	public float moveSpeed = 10;

	public float jumpHeight = 500;
	public float multiplier;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//Move the player to the left
		if(Input.GetKey(KeyCode.A)){
			//vector 3 X , Y , Z
			//Multiplying by deltaTime will mean the movespeed modifier applies every second rather than every frame
			transform.Translate(new Vector3(-moveSpeed,0,0) * Time.deltaTime );
		}
		//Move the player to the right
		if(Input.GetKey(KeyCode.D)){
			transform.Translate(new Vector3(moveSpeed,0,0)* Time.deltaTime);
		}
		//Move the player up
		if(Input.GetKey(KeyCode.W)){
			transform.Translate(new Vector3(0,moveSpeed,0)* Time.deltaTime);
		}

		//Move the player down
		if(Input.GetKey(KeyCode.S)){
			transform.Translate(new Vector3(0,-moveSpeed,0)* Time.deltaTime);
		}

		//Jump handler

		if(Input.GetKeyDown(KeyCode.Space)){
			rigidbody2D.AddForce(Vector2.up * jumpHeight);
		}


	
	}
}
