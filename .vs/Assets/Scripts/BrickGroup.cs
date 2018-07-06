using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BrickGroup : MonoBehaviour {

    protected WaveSpawner ws;
    

	void Start ()
    {
        ws = GameObject.Find("WaveSpawner").GetComponent<WaveSpawner>();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "shredder")
        {
            Destroy(ws.GroupATM, .3f);
            ws.onceATM = true;
        }
    }
}
