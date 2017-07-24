using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Countdownscript : MonoBehaviour {
    
    public int starttid = 60;
    public float sluttid = 0;
    public Text countdownText;

    // Use this for initialization
    void Start () {
	    
	}
	
	//Update is called once per frame
	void Update () {
        Nedtælling();
	}
        
        public void Nedtælling()
  {
        starttid -= Time.deltatime;

        if (starttid <= sluttid) {
        SceneManager.LoadScene("Winscene");
        }
       
    }
        
}
