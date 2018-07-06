using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPlayer : MonoBehaviour {

    protected Ask ask;
    public int lives;
    public bool blockOnMe;
    protected SecondPlayer sp;
	void Start ()
    {
        ask = GameObject.Find("Ask").GetComponent<Ask>();
        lives = 5;
        sp = GameObject.Find("SPlayer").GetComponent<SecondPlayer>();
        blockOnMe = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ask")
        {
            blockOnMe = true;
            Debug.Log("Bloque ASK sobre el Primer jugador, ESTADO: " + blockOnMe);
        }
        if (other.gameObject.tag == "E_Life")
        {
            lives++;
        }
        if (other.gameObject.tag == "Dmg")
        {
            lives--;
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Ask")
        {
            blockOnMe = false;
        }
    }
    public void WrongAnswer()
    {
        Debug.Log("Wrong Answer :C");
    }
}
