using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour {

    public GameObject ball;
    public Cinemachine.CinemachineVirtualCamera regularCam;
    public Cinemachine.CinemachineVirtualCamera zoomedCam;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (ball.transform.position.x > 0){
            zoomedCam.gameObject.SetActive(true);
            regularCam.gameObject.SetActive(false);
        }
        else{
            zoomedCam.gameObject.SetActive(false);
            regularCam.gameObject.SetActive(true);
        }
	}
}
