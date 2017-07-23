using UnityEngine;
using System.Collections;

public class Skildmoves : MonoBehaviour {

    public float moveSpeed = 20;
    public Rigidbody myRigidbody;
    public float rotationSpeed = 60;

    // Use this for initialization
    void Start () {
        
    }

	// Update is called once per frame
	void Update () {
        transform.Rotate(0, rotationSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0);
	}

    void FixedUpdate() {
        Move(moveSpeed * Input.GetAxis("Vertical"));
    }

    void Move(float speed) {
        myRigidbody.velocity = transform.forward * speed + Vector3.up * myRigidbody.velocity.y;
    }
}
