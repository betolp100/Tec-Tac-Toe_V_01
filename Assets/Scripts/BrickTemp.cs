using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickTemp : MonoBehaviour {

    protected Animator anim;
    protected WaveSpawner ws;

    protected Ask ask;

	void Start ()
    {
        ask = GameObject.Find("Ask").GetComponent<Ask>();

        anim = GetComponent<Animator>();
        ws = GameObject.Find("WaveSpawner").GetComponent<WaveSpawner>();
        if(ws.temp<10)
        anim.speed = (ws.temp*.01f+1f);

        if (ws.temp > 10&& ws.temp<35)
            anim.speed = (ws.temp * .01f + .75f);

        if (ws.temp > 35)
            anim.speed = (ws.temp * .009f+1f );
    }
	
}
