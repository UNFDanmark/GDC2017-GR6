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
    public AudioSource myAudio;
    public AudioClip KrappeKlitren;

    // Use this for initialization
    void Awake() {

        bølge = FindObjectOfType<Bølgescript>();

        myAudio = GetComponent < AudioSource > ();
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
        if (distanceFraSkildpadde <= minimumDistance && DetermineClosestCrab() == this.gameObject)
        {
            navigationAgent.destination = playerSkildpadde.transform.position;

            navigationAgent.speed = hastighedIndenforSkildpadde;

            if (myAudio.isPlaying == false)
            {
                myAudio.Play();
            }

        }
        else if (distanceFraDestination <= tætPåDestination)
        {
            navigationAgent.destination = new Vector3(Random.Range(-65, 66), Krappeafstandfrajord, Random.Range(-65, 66));

            navigationAgent.speed = hastighedUdenforSkildpadde;
        }

    }

    public GameObject DetermineClosestCrab() {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        GameObject closest = null;
        float distance = 99999999;

        foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy")) {
            if (enemy.GetComponent<Krappemoves>() != null) {
                float thisDistance = (playerSkildpadde.transform.position - enemy.transform.position).magnitude;

                if (thisDistance < distance) {
                    distance = thisDistance;
                    closest = enemy;
                }
            }
        }
        
        return closest;
    }

        
}
