using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ask : MonoBehaviour {

    protected FirstPlayer fp;
    protected SecondPlayer sp;

    private GameObject card;

    public GameObject[] cards;
    public Sprite[] answerCards0, answerCards1;
    public GameObject wrong, correct, effect;

    private GameObject[] dmgB, eLifeB, askB;
    public GameObject canvas;

    private int random, player;

    public bool isAsking, makingChoice, rightAnswer;

	void Start ()
    {
        fp = GameObject.Find("FPlayer").GetComponent<FirstPlayer>();
        sp = GameObject.Find("SPlayer").GetComponent<SecondPlayer>();
        isAsking = false;
        makingChoice = false;
        rightAnswer = false;

        
    }

    // Update is called once per frame
    void Update ()
    {
        
        RandomizePlayer();
        if (makingChoice == true)
        {
            Debug.Log("Cuadro Izq apareciendo");
            Debug.Log(player + " Player");
            if (player == 1)
            {
                
                if (Input.GetButtonDown("HorizontalP1") && Input.GetAxisRaw("HorizontalP1") > 0)
                {
                    //MoveRight
                    Debug.Log(card.name);
                    rightAnswer = true;
                    if (random == 0)
                    {
                        card.GetComponent<Animator>().SetBool("isB", true);
                        card.GetComponent<Animator>().SetBool("isA",false);
                    }
                    else
                   if (random == 1)
                    {
                        card.GetComponent<Animator>().SetBool("isB", true);
                        card.GetComponent<Animator>().SetBool("isA", false);
                    }
                    Debug.Log("Move Right");


                }
                else if (Input.GetButtonDown("HorizontalP1") && Input.GetAxisRaw("HorizontalP1") < 0)
                {
                    //Move Left
                    rightAnswer = false;
                    Debug.Log(card.name);
                    if (random == 0)
                    {
                        card.GetComponent<Animator>().SetBool("isA", true);
                        card.GetComponent<Animator>().SetBool("isB", false);
                    }
                    else
                    if (random == 1)
                    {
                        card.GetComponent<Animator>().SetBool("isA", true);
                        card.GetComponent<Animator>().SetBool("isB",false);
                    }
                    Debug.Log("Move Left");

                }

                //if (Input.GetKeyDown(KeyCode.F) && rightAnswer == true)
                if (Input.GetButtonDown("EnterP1") && Input.GetAxisRaw("EnterP1") > 0 && rightAnswer == true)
                {
                    Debug.Log("Enter");
                    switch (random)
                    {
                        case 0:
                            Destroy(card, 0.2f);
                            CheckAnswer(false);
                            break;

                        case 1:
                            Destroy(card, 0.2f);
                            CheckAnswer(true);
                            break;

                    }
                }

                else //if (Input.GetKeyDown(KeyCode.F) && rightAnswer == false)
                    if (Input.GetButtonDown("EnterP1") && Input.GetAxisRaw("EnterP1") > 0 && rightAnswer == false)
                    {
                        Debug.Log("Enter");
                        switch (random)
                        {
                            case 0:
                                Destroy(card, 0.2f);
                                CheckAnswer(true);

                                break;

                            case 1:
                                Destroy(card, 0.2f);
                                CheckAnswer(false);

                            break;

                        }
                    }
            }

            else if (player == 2)
            {
                Debug.Log("Esperando Inputs");
                if (Input.GetKeyDown(KeyCode.RightArrow))
                //if (Input.GetButtonDown("HorizontalP2") && Input.GetAxisRaw("HorizontalP2") > 0 )
                {
                    //MoveRight
                    Debug.Log("ÑAaaaa");
                    Debug.Log(card.name);
                    rightAnswer = true;
                    if (random == 0)
                    {
                        card.GetComponent<Animator>().SetBool("isB", true);
                        card.GetComponent<Animator>().SetBool("isA", false);
                    }
                    else
                    if (random == 1)
                    {
                        card.GetComponent<Animator>().SetBool("isB", true);
                        card.GetComponent<Animator>().SetBool("isA", false);
                    }

                    Debug.Log("Move Right");


                }
                else if (Input.GetKeyDown(KeyCode.LeftArrow))
                //if (Input.GetButtonDown("HorizontalP2") && Input.GetAxisRaw("HorizontalP2") < 0)
                {
                    //Move Left
                    Debug.Log("Banana");
                    Debug.Log(card.name);
                    rightAnswer = false;

                    if (random == 0)
                    {
                        card.GetComponent<Animator>().SetBool("isA", true);
                        card.GetComponent<Animator>().SetBool("isB", false);
                    }
                    else
                    if (random == 1)
                    {
                        card.GetComponent<Animator>().SetBool("isA", true);
                        card.GetComponent<Animator>().SetBool("isB", false);
                    }
                    Debug.Log("Move Left");

                }

                //if (Input.GetKeyDown(KeyCode.m) && rightAnswer == true)
                if (Input.GetButtonDown("EnterP2") && Input.GetAxisRaw("EnterP2") > 0 && rightAnswer == true)
                {
                    Debug.Log("Enter");
                    switch (random)
                    {
                        case 0:
                            Destroy(card, 0.2f);
                            CheckAnswer(false);
                            break;

                        case 1:
                            Destroy(card, 0.2f);
                            CheckAnswer(true);
                            break;

                    }
                }

                else //if (Input.GetKeyDown(KeyCode.m) && rightAnswer == false)
                if (Input.GetButtonDown("EnterP2") && Input.GetAxisRaw("EnterP2") > 0 && rightAnswer == false)
                {
                    Debug.Log("Enter");
                    switch (random)
                    {
                        case 0:
                            Destroy(card, 0.2f);
                            CheckAnswer(true);

                            break;

                        case 1:
                            Destroy(card, 0.2f);
                            CheckAnswer(false);

                            break;

                    }
                }
            }
        }
	}

    public void MakeQuestion()
    {
        dmgB = GameObject.FindGameObjectsWithTag("Dmg");
        eLifeB = GameObject.FindGameObjectsWithTag("E_Life");
        askB = GameObject.FindGameObjectsWithTag("Ask");

        for (int i = 0; i < dmgB.Length; i++)
        {
            Destroy(dmgB[i],1F);
        }
        for (int i = 0; i < eLifeB.Length; i++)
        {
            Destroy(eLifeB[i],1F);
        }
        for (int i = 0; i < askB.Length; i++)
        {
            Destroy(askB[i],1F);
        }
        isAsking = true;
        if (player == 1)
        {
            
            Debug.Log("Question Goes to the First Player");
            random = Random.Range(0, 1);

            card = Instantiate(cards[random], cards[random].transform.position, cards[random].transform.rotation) as GameObject;
            card.transform.transform.SetParent(canvas.transform);
            card.transform.localPosition = cards[random].transform.position;
            card.transform.localRotation = cards[random].transform.rotation;
            StartCoroutine(MakeAnswer());

        }
        if (player == 2)
        {
            Debug.Log("Question Goes to the Second Player");
            random = Random.Range(0, 2);

            card = Instantiate(cards[random], cards[random].transform.position, cards[random].transform.rotation) as GameObject;
            card.transform.transform.SetParent(canvas.transform);
            card.transform.localPosition = cards[random].transform.position;
            card.transform.localRotation = cards[random].transform.rotation;
            StartCoroutine(MakeAnswer());
        }
        
    }

    IEnumerator MakeAnswer()
    {
        yield return new WaitForSeconds(2f);
        if (random == 0)
        {
            cards[random].GetComponent<Image>().sprite = answerCards0[0];
        }
        else
                   if (random == 1)
        {
            cards[random].GetComponent<Image>().sprite = answerCards1[0];
        }
        makingChoice = true;
        
        
    }

    public void CheckAnswer(bool answer)
    {
        if (answer == true)
        {
            Debug.Log("Correcto");
            effect = Instantiate(correct, correct.transform.position, correct.transform.rotation) as GameObject;
            effect.transform.transform.SetParent(canvas.transform);
            effect.transform.localPosition = correct.transform.position;
            effect.transform.localRotation = correct.transform.rotation;
            Destroy(effect, 2f);
            //NO QUITAR VIDA, CONTINAR JUEGO
        }
        else
        {
            Debug.Log("Incorrecto");
            effect = Instantiate(wrong, wrong.transform.position, wrong.transform.rotation) as GameObject;
            effect.transform.transform.SetParent(canvas.transform);
            effect.transform.localPosition = wrong.transform.position;
            effect.transform.localRotation = wrong.transform.rotation;
            Destroy(effect, 2f);
            if (player == 1)
            {
                fp.lives--;
            }
            else if (player == 2)
            {
                sp.lives--;
            }
            //QUITAR VIDA, CONTINUAR JUEGO
        }
        isAsking = false;
        makingChoice = false;
        
    }

    public void RandomizePlayer()
    {
        if (fp.blockOnMe == true && sp.blockOnMe == true)
        {
            fp.blockOnMe = false;
            sp.blockOnMe = false;
            int i = Random.Range(1, 3);
            player = i;
            Debug.Log("pregunta para el jugador: " + player);
            MakeQuestion();
        }
        else if (fp.blockOnMe == true && sp.blockOnMe == false)
        {
            fp.blockOnMe = false;
            player = 1;
            Debug.Log("pregunta para el jugador: " + player);
            MakeQuestion();
        }
        else if (fp.blockOnMe == false && sp.blockOnMe == true)
        {
            sp.blockOnMe = false;
            player = 2;
            Debug.Log("pregunta para el jugador: " + player);
            MakeQuestion();
        }else if((fp.blockOnMe==false) && (sp.blockOnMe == false))
        {

        }

        ;
    }
}
