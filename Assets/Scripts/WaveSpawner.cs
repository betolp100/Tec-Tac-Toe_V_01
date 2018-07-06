using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WaveSpawner : MonoBehaviour {

    protected Ask ask;

    public GameObject[] Groups;
    public float countDown, temp=0;
    public GameObject GroupATM=null;
    public bool onceATM;
    public Text timer;

    BoxCollider bc_shredder, bc_gatm;

	void Start ()
    {
        countDown = 5f;
        onceATM = true;

        ask = GameObject.Find("Ask").GetComponent<Ask>();
    }

    void Update()
    {
        if (ask.isAsking==false)
        {
            if (countDown == 0 && onceATM)
            {
                int i = Random.Range(0, 12);
                GroupATM = Instantiate(Groups[i], Groups[i].transform.position, Groups[i].transform.rotation);
                onceATM = false;
            }
            else
            {
                countDown -= Time.deltaTime;
                countDown = Mathf.Clamp(countDown, 0f, Mathf.Infinity);
                temp += Time.deltaTime;
                timer.text = temp.ToString();
            }
        }
    }

    
}
