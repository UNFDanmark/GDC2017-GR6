using UnityEngine;
using System.Collections;


public class Kamerascripts : MonoBehaviour {

    public GameObject Skildpadde;
    public Vector3 PindTilSkildpadde; 

	// Use this for initialization
	void Start () {

        PindTilSkildpadde = transform.position - Skildpadde.transform.position;

	}
	
	// Update is called once per frame
	void Update () {

        transform.position = PindTilSkildpadde + Skildpadde.transform.position;
    	
	}
}
