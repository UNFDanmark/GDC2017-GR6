using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownBane2Script : MonoBehaviour {

    public float starttid = 60;
    public float sluttid = 0;
    public Text tidsText;
    public BølgeBane2Script bølge;

    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
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
