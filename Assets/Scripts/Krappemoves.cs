using UnityEngine;
using System.Collections;

public class Krappemoves : MonoBehaviour {

    public Rigidbody KrapsRigidbody;
    public float moveSpeed = 20;
    public float rotationSpeed = 60;
    Transform player;
   

    void Awake ()
    {
        player = GameObject.FindGameObjectWithTag("Skildpadde").transform;

     

    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
