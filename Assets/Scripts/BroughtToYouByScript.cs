using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BroughtToYouByScript : MonoBehaviour {

    public float commercialTime = 2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (commercialTime <= 0)
        {
            MainMenu();
        }
        commercialTime -= Time.deltaTime;
	}

    public void MainMenu()
    {

        SceneManager.LoadScene("Hovedmenu");

    }
}
