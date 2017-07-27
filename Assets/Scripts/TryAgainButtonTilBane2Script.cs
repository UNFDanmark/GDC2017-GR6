using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TryAgainButtonTilBane2Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void TryAgainLevel2()
    {
        SceneManager.LoadScene("Bane 2");

    }
}
