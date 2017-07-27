using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntrosceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetKeyDown(KeyCode.Space))        
        {

            SceneManager.LoadScene("Bane 1");

        }

        }

    

}
