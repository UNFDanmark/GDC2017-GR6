using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevelBane2Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void NextLevel()
    {

        SceneManager.LoadScene("Bane 3");

    }
}
