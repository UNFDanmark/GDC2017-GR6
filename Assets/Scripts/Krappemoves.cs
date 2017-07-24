using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Krappemoves : MonoBehaviour 
{

    public Rigidbody KrapsRigidbody;
    public NavMeshAgent navigationAgent;
    public Skildmoves playerSkildpadde;
    public float minimumDistance = 15;
    
    // Use this for initialization
    void Start () { 
	
	}
	
	// Update is called once per frame
	void Update () {
        float distanceFraSkildpadde = (playerSkildpadde.transform.position - transform.position).magnitude;
        
        if (distanceFraSkildpadde <= minimumDistance) {
            navigationAgent.destination = playerSkildpadde.transform.position;
        }
        else {
            navigationAgent.destination = Random.Rang
                    }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            KillPlayer();
        }
    }
    public void KillPlayer()

    {
        SceneManager.LoadScene("Losescene");

    }
        
}
