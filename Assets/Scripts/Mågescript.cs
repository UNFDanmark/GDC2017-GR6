using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class Mågescript : MonoBehaviour
{
    public Rigidbody MågesRigidbody;
    public NavMeshAgent NavMeshAgent;
    public Skildmoves playerSkildpadde;
    public Krappemoves Krappemoves;
    public float minimumDistance = 15;
    public float sidsteDestination = 0;
    public float nyDestination = 5;
    public GameObject Mågefigur;
    public float hastighedIndenforSkildpadde = 20;
    public float hastighedUdenforSkildpadde = 15;
    public float nyDestinationIndenforSkildpadde = 5;
    public float sidsteDestinationIndeforSkildpadde = 0; 
    
    

    // Use this for initialization
    void Start()
    {
        Reset();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift)) {

            Reset();
        }
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    void OnTriggerEnter(Collider mågeCollision)
    {
        if (mågeCollision.CompareTag("Player") && playerSkildpadde.inSideShield == false)
        {
            Krappemoves.KillPlayer();
        }
    }

    public void Move()
    {
        float distanceFraSkildpadde = (playerSkildpadde.transform.position - transform.position).magnitude;
        Mågefigur.transform.position = new Vector3(transform.position.x, distanceFraSkildpadde, transform.position.z);

        if (playerSkildpadde.inSideShield == false) { 
            if (distanceFraSkildpadde <= minimumDistance)
            {
            
                    NavMeshAgent.destination = playerSkildpadde.transform.position;

                    NavMeshAgent.speed = hastighedIndenforSkildpadde;
               
            }

           else if ((Time.time - sidsteDestinationIndeforSkildpadde) >= nyDestinationIndenforSkildpadde)
           { 

                sidsteDestinationIndeforSkildpadde = Time.time;

                NavMeshAgent.destination = new Vector3(Random.Range(-45, 46), 1.5f, Random.Range(-45, 46));
            }
        }

        
        else if ((Time.time - sidsteDestination) >= nyDestination)
        {

            sidsteDestination = Time.time;

            NavMeshAgent.destination = new Vector3(Random.Range(-45, 46), 1.5f, Random.Range(-45, 46));
            print(gameObject.name + " " + NavMeshAgent.destination);

            NavMeshAgent.speed = hastighedUdenforSkildpadde; 
        }
    }

    public void Reset()
    {
        sidsteDestination = -nyDestination;
        sidsteDestinationIndeforSkildpadde = -nyDestinationIndenforSkildpadde;

    }
}