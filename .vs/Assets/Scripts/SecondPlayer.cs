using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPlayer : MonoBehaviour {

    protected Ask ask;
    public int lives;
    public bool blockOnMe;
    protected FirstPlayer fp;
    void Start()
    {
        ask = GameObject.Find("Ask").GetComponent<Ask>();
        fp = GameObject.Find("FPlayer").GetComponent<FirstPlayer>();
        lives = 5;
        blockOnMe = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ask")
        {
            blockOnMe = true;
            Debug.Log("Bloque ASK sobre el Segundo jugador, ESTADO: " + blockOnMe);
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
