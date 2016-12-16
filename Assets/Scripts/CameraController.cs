using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;


	// Use this for initialization
	void Start () {
        // Need camera to track with player based on relitive position
        offset = transform.position - player.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
	}

    // Runs on every frame AFTER all items have been processed
    private void LateUpdate() {
        transform.position = player.transform.position + offset;
    }
}
