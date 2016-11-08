using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{
    public float moveSpeed;
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += (Vector3.forward + (-Vector3.right))* moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += ((-Vector3.forward) + (-Vector3.right)) * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += ((-Vector3.forward) + Vector3.right) * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += (Vector3.forward + Vector3.right) * moveSpeed * Time.deltaTime;
        }

    }
}
