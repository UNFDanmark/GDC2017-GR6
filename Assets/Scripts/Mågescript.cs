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
    public GameObject Mågefigur;
    public float hastighedIndenforSkildpadde = 20;
    public float hastighedUdenforSkildpadde = 15;
    public float tætPåDestinationDistance = 1; 
    
    

    // Use this for initialization
    void Start()
    {
        ResetPosition();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {

            ResetPosition();
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

        float distanceFraDestination = (NavMeshAgent.destination - transform.position).magnitude; 

        if (playerSkildpadde.inSideShield == false) { 
            if (distanceFraSkildpadde <= minimumDistance)
            {
            
                    NavMeshAgent.destination = playerSkildpadde.transform.position;

                    NavMeshAgent.speed = hastighedIndenforSkildpadde;
               
            }

      else if (distanceFraDestination <= tætPåDestinationDistance)
           {

                ResetPosition();
                
            }
        }

        
        else if (distanceFraDestination <= tætPåDestinationDistance)
        {

            ResetPosition();

            print(gameObject.name + " " + NavMeshAgent.destination);

            NavMeshAgent.speed = hastighedUdenforSkildpadde; 
        }
    }

    public void ResetPosition()
    {
        NavMeshAgent.destination = new Vector3(Random.Range(-65, 66), 1.5f, Random.Range(-65, 66));
    }
}