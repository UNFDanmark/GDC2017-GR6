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
    
    

    // Use this for initialization
    void Start()
    {
        sidsteDestination = -nyDestination;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    void OnCollisionEnter(Collision mågeCollision)
    {
        if (mågeCollision.collider.CompareTag("Player") && playerSkildpadde.inSideShield == false)
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
            else {
                NavMeshAgent.destination = new Vector3(Random.Range(-48, 49), 2, Random.Range(-48, 49));
            }
        }
        
        else if ((Time.time - sidsteDestination) >= nyDestination)
        {

            sidsteDestination = Time.time;

            NavMeshAgent.destination = new Vector3(Random.Range(-48, 49), 2, Random.Range(-48, 49));
            print(gameObject.name + " " + NavMeshAgent.destination);

            NavMeshAgent.speed = hastighedUdenforSkildpadde; 
        }
    }
}