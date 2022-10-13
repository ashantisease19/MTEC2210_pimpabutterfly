using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
	public AudioClip coinclip;
	public AudioClip hazardclip;
	private float speed;
	public GameManager gm;
	// Start is called before the first frame update
	void Start()
	{
		Debug.Log(transform.position.x);


	}


	// Update is called once per frame
	void Update()
	{
		//float xMove = Input.GetAxis("Horizontal");

		if (Input.GetKey(KeyCode.A))
		{
			speed = -10;
		}
		else if (Input.GetKey(KeyCode.D))
		{

			speed = 10;
		}
		else
		{
			speed = 0;
		}
		transform.Translate(speed * Time.deltaTime, 0, 0);
	}

	private void OnTriggerEnter2D(Collider2D collision) 
	{
		if (collision.gameObject.tag == "Coin")
		{
			gm.IncrementScore(1);

			gm.PlaySound(coinclip);
			Destroy(collision.gameObject);
		}

		if (collision.gameObject.tag == "Hazard")
		{
			gm.PlaySound(hazardclip);
			Destroy(gameObject);

        }		
		if (collision.gameObject.tag == "Theme")
        {
			Destroy(collision.gameObject);
			Destroy(gameObject);
			Debug.Log("Theme Changed :)");
        }
	}
}
 
