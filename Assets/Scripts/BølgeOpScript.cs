using UnityEngine;
using System.Collections;

public class BølgeOpScript : MonoBehaviour {

    public float tidForBølge = 0;
    public float glideTime = 2.5f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        tidForBølge += Time.deltaTime;

        transform.position = new Vector3(transform.position.x, Mathf.Lerp(200, 1300, tidForBølge / glideTime), 0);
    }
}
