using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	Rigidbody2D rigidBody;
	[SerializeField] float speed = 6f;
	[SerializeField] GameObject gameOverpanel;
	bool grounded;

    void Start()
    {
    	gameOverpanel.SetActive(false);
    	rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    	if(transform.position.y <= -1)
    	{
    		gameOverpanel.SetActive(true);
    		Destroy(gameObject);
    	}
    	if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
    		transform.Translate(new Vector2( speed * Time.deltaTime, 0));
    	}
    	
    	if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
    		transform.Translate(new Vector2( -speed * Time.deltaTime, 0));
    	}
    	
    	if(Input.GetKey(KeyCode.Space) && grounded == true){
    		rigidBody.velocity = new Vector2(rigidBody.velocity.x , 6);
    	}
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
    	Debug.Log("collides with ground");
    	if(other.gameObject.tag == "Ground")
    		grounded = true;
    }
    
    void OnCollisionExit2D(Collision2D other)
    {
    	if(other.gameObject.tag == "Ground")
    		grounded = false;
    }
}
