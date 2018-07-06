using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class borrarahorita : MonoBehaviour {

    public Sprite imgn;
    protected SpriteRenderer to;

	void Start () {
        to = GameObject.Find("qu").GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F))
        {
            to.sprite = imgn;
        }	
	}
}
