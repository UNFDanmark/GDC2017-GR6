using UnityEngine;
using System.Collections;

public class Skildmoves : MonoBehaviour {

    public float moveSpeed = 20;
    public Rigidbody myRigidbody;
    public float rotationSpeed = 60;
    public bool inSideShield = false;
    public GameObject modelinside;  
    public GameObject modeloutside;
 

    // Use this for initialization
    void Start () {
    }

	// Update is called once per frame
    public void Update () {

    }
    public void FixedUpdate() {
        Move(moveSpeed * Input.GetAxis("Vertical"));
        transform.Rotate(0, rotationSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0);
        if(Input.GetKey(KeyCode.LeftShift))
        {
            inSideShield = true;
            modelinside.SetActive(true);
            modeloutside.SetActive(false);
            myRigidbody.velocity = Vector3.zero; 
        }
        else {
            inSideShield = false;
            modelinside.SetActive(false);
            modeloutside.SetActive(true);
        }
    }


    void Move(float speed) {
    if(inSideShield == false)
        myRigidbody.velocity = transform.forward * speed + Vector3.up * myRigidbody.velocity.y;
    }

}
