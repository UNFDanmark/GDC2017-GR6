using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuButtonScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        MainMenu();

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Hovedmenu");
    }
}
