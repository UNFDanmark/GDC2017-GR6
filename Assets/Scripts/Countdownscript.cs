using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Countdownscript : MonoBehaviour {
    
    public float starttid = 60;
    public float sluttid = 0;
    public Text tidsText;
    public Bølgescript bølge; 

    // Use this for initialization
    void Start () {
	    
	}

    //Update is called once per frame
    void Update()
    {
        Nedtælling();
    }

    public void Nedtælling()
    {
        starttid -= Time.deltaTime;

        tidsText.text = "Time: " + starttid.ToString("N1");

        if (starttid <= sluttid)
        {
            Win(); 

        }


    }

    public void Win()
    {
        bølge.harViVundet = true;

    }

}

