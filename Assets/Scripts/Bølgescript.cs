using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Bølgescript : MonoBehaviour {

    public bool harViVundet = false;
    public float tidForBølge = 0;
    public float glideTime = 2;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    if(harViVundet == true) 
        {
            tidForBølge += Time.deltaTime;

           transform.position = new Vector3(transform.position.x, Mathf.Lerp(Screen.currentResolution.height, 200, tidForBølge / glideTime), 0);
            

            if (tidForBølge > glideTime + 0.5) {
                SceneManager.LoadScene("Winscene");
                }
        }
	}
}
