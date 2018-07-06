using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour {

    public Color green, orange, red, purple, white;
    protected Renderer rend;
    protected GameMaster gm;
    
	void Start () {
        gm = GameObject.Find("GameMaster").GetComponent<GameMaster>();
        rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (gm.FPlayer.position == transform.position)
        {
            rend.material.color = green;
        }
        else if (gm.SPlayer.position == transform.position)
        {
            rend.material.color = orange;
        }
        else
        {
            rend.material.color = white;
        }
    }
}
