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
    public float sidsteDestination = 0;
    public float nyDestination = 5;
    public float Krappeafstandfrajord = 0.5f;
    public float hastighedIndenforSkildpadde = 20;
    public float hastighedUdenforSkildpadde = 15;

    // Use this for initialization
    void Start () {
        sidsteDestination = -nyDestination;
	}
	
	// Update is called once per frame
	void Update () {

        Move();
       
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            KillPlayer();
        }
        if (collision.collider.CompareTag("HiddenPlayer"))
        {
            KillPlayer();
        }
    }
    public void KillPlayer()

    {
        SceneManager.LoadScene("Losescene");

    }

    public void Move()
    {
        float distanceFraSkildpadde = (playerSkildpadde.transform.position - transform.position).magnitude;

        if (distanceFraSkildpadde <= minimumDistance)
        {
            navigationAgent.destination = playerSkildpadde.transform.position;

            navigationAgent.speed = hastighedIndenforSkildpadde;
        }
        else if ((Time.time - sidsteDestination) >= nyDestination)
        {

            sidsteDestination = Time.time;

            navigationAgent.destination = new Vector3(Random.Range(-48, 49), Krappeafstandfrajord, Random.Range(-48, 49));

            navigationAgent.speed = hastighedUdenforSkildpadde;

        }

    }

        
}
