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
    public float Krappeafstandfrajord = 0.5f;
    public float hastighedIndenforSkildpadde = 20;
    public float hastighedUdenforSkildpadde = 15;
    public float tætPåDestination = 1;
    public Bølgescript bølge;
    // Use this for initialization
    void Awake() {
        bølge = FindObjectOfType<Bølgescript>();
    }
    void Start () {
        navigationAgent.destination = new Vector3(Random.Range(-65, 66), Krappeafstandfrajord, Random.Range(-65, 66));
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
        if(bølge.harViVundet == false) {
            SceneManager.LoadScene("Losescene");
        }
    }

    public void Move()
    {
        float distanceFraSkildpadde = (playerSkildpadde.transform.position - transform.position).magnitude;
        float distanceFraDestination = (navigationAgent.destination - transform.position).magnitude;
        print(distanceFraDestination);
        if (distanceFraSkildpadde <= minimumDistance)
        {
            navigationAgent.destination = playerSkildpadde.transform.position;

            navigationAgent.speed = hastighedIndenforSkildpadde;
        }
        else if (distanceFraDestination <= tætPåDestination)
        {
            navigationAgent.destination = new Vector3(Random.Range(-65, 66), Krappeafstandfrajord, Random.Range(-65, 66));

            navigationAgent.speed = hastighedUdenforSkildpadde;
        }

    }

        
}
