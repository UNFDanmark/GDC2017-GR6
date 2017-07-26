using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Losescript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Retry();
    }

    public void Retry()
    {
        SceneManager.LoadScene("Bane 1");
    }

}
