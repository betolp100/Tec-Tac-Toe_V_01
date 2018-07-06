using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

    protected Ask ask;

    public Transform FPlayer, SPlayer;
    public Transform Inode1, Inode2, Inode3, IInode1, IInode2, IInode3, IIInode1, IIInode2, IIInode3;

    [HideInInspector]
    public bool FOnInode1, FOnInode2, FOnInode3, FOnIInode1, FOnIInode2, FOnIInode3, FOnIIInode1, FOnIIInode2, FOnIIInode3;
    [HideInInspector]
    public bool SOnInode1, SOnInode2, SOnInode3, SOnIInode1, SOnIInode2, SOnIInode3, SOnIIInode1, SOnIIInode2, SOnIIInode3;

    private void Start()
    {
        FPlayer.position = IInode1.position;
        SPlayer.position = IInode3.position;

        ask = GameObject.Find("Ask").GetComponent<Ask>();

    }

    void Update()
    {

        if (ask.isAsking == false)
        {
            //Region about if the Player1 is on "X" node;
            #region
            if (FPlayer.position == Inode1.position)
            {
                FOnInode1 = true;
            }
            else FOnInode1 = false;

            if (FPlayer.position == Inode2.position)
            {
                FOnInode2 = true;
            }
            else FOnInode2 = false;

            if (FPlayer.position == Inode3.position)
            {
                FOnInode3 = true;
            }
            else FOnInode3 = false;

            if (FPlayer.position == IInode1.position)
            {
                FOnIInode1 = true;
            }
            else FOnIInode1 = false;

            if (FPlayer.position == IInode2.position)
            {
                FOnIInode2 = true;
            }
            else FOnIInode2 = false;

            if (FPlayer.position == IInode3.position)
            {
                FOnIInode3 = true;
            }
            else FOnIInode3 = false;

            if (FPlayer.position == IIInode1.position)
            {
                FOnIIInode1 = true;
            }
            else FOnIIInode1 = false;

            if (FPlayer.position == IIInode2.position)
            {
                FOnIIInode2 = true;
            }
            else FOnIIInode2 = false;

            if (FPlayer.position == IIInode3.position)
            {
                FOnIIInode3 = true;
            }
            else FOnIIInode3 = false;
            #endregion

            #region
            if (SPlayer.position == Inode1.position)
            {
                SOnInode1 = true;
            }
            else SOnInode1 = false;

            if (SPlayer.position == Inode2.position)
            {
                SOnInode2 = true;
            }
            else SOnInode2 = false;

            if (SPlayer.position == Inode3.position)
            {
                SOnInode3 = true;
            }
            else SOnInode3 = false;

            if (SPlayer.position == IInode1.position)
            {
                SOnIInode1 = true;
            }
            else SOnIInode1 = false;

            if (SPlayer.position == IInode2.position)
            {
                SOnIInode2 = true;
            }
            else SOnIInode2 = false;

            if (SPlayer.position == IInode3.position)
            {
                SOnIInode3 = true;
            }
            else SOnIInode3 = false;

            if (SPlayer.position == IIInode1.position)
            {
                SOnIIInode1 = true;
            }
            else SOnIIInode1 = false;

            if (SPlayer.position == IIInode2.position)
            {
                SOnIIInode2 = true;
            }
            else SOnIIInode2 = false;

            if (SPlayer.position == IIInode3.position)
            {
                SOnIIInode3 = true;
            }
            else SOnIIInode3 = false;
            #endregion

            /*|| FPlayer.position==Inode2.position || FPlayer.position==Inode3.position
                    || FPlayer.position==IInode1.position || FPlayer.position==IInode2.position || FPlayer.position==IInode3.position 
                    || FPlayer.position==IIInode1.position || FPlayer.position==IIInode2.position || FPlayer.position == IIInode3.position)*/
            MovePlayers();

        }
    }

        void MovePlayers()
        {
            //Region which move the players positions
            //-------------------------------------------------------------------------------
            //FIRST PLAYER
            #region
            if (FOnInode1)
            {
                if (Input.GetButtonDown("HorizontalP1") && Input.GetAxisRaw("HorizontalP1") > 0 && SPlayer.position != Inode2.position)
                {
                    //Move Right
                    Debug.Log("Move Right");
                    FOnInode1 = false;
                    FPlayer.position = Inode2.position;
                    FOnInode2 = true;

                }
                else if (Input.GetButtonDown("VerticalP1") && Input.GetAxisRaw("VerticalP1") > 0 && SPlayer.position != IInode1.position)
                {
                    //Move Up
                    Debug.Log("Move Up");
                    FOnInode1 = false;
                    FPlayer.position = IInode1.position;
                    FOnIInode1 = true;
                }
            }
            else if (FOnInode2)
            {
                if (Input.GetButtonDown("HorizontalP1") && Input.GetAxisRaw("HorizontalP1") > 0 && SPlayer.position != Inode2.position)
                {
                    //Move Right
                    Debug.Log("Move Right");
                    FOnInode2 = false;
                    FPlayer.position = Inode3.position;
                    FOnInode3 = true;
                }
                else if (Input.GetButtonDown("HorizontalP1") && Input.GetAxisRaw("HorizontalP1") < 0 && SPlayer.position != Inode1.position)
                {
                    //Move Left
                    Debug.Log("Move Left");
                    FOnInode2 = false;
                    FPlayer.position = Inode1.position;
                    FOnInode1 = true;
                }
                else if (Input.GetButtonDown("VerticalP1") && Input.GetAxisRaw("VerticalP1") > 0 && SPlayer.position != IInode2.position)
                {
                    //Move Up
                    Debug.Log("Move Up");
                    FOnInode2 = false;
                    FPlayer.position = IInode2.position;
                    FOnIInode2 = true;
                }
            }
            else if (FOnInode3)
            {
                if (Input.GetButtonDown("HorizontalP1") && Input.GetAxisRaw("HorizontalP1") < 0 && SPlayer.position != Inode2.position)
                {
                    // Move Left
                    Debug.Log("Move Left");
                    FOnInode3 = false;
                    FPlayer.position = Inode2.position;
                    FOnInode2 = true;
                }
                else if (Input.GetButtonDown("VerticalP1") && Input.GetAxisRaw("VerticalP1") > 0 && SPlayer.position != IInode3.position)
                {
                    //Move Up
                    Debug.Log("Move Up");
                    FOnInode3 = false;
                    FPlayer.position = IInode3.position;
                    FOnIInode3 = true;
                }
            }
            else if (FOnIInode1)
            {
                if (Input.GetButtonDown("HorizontalP1") && Input.GetAxisRaw("HorizontalP1") > 0 && SPlayer.position != IInode2.position)
                {
                    //Move Right
                    Debug.Log("Move Right");
                    FOnIInode1 = false;
                    FPlayer.position = IInode2.position;
                    FOnIInode2 = true;
                }
                else if (Input.GetButtonDown("VerticalP1") && Input.GetAxisRaw("VerticalP1") > 0 && SPlayer.position != IIInode1.position)
                {
                    //Move Top
                    Debug.Log("Move Top");
                    FOnIInode1 = false;
                    FPlayer.position = IIInode1.position;
                    FOnIIInode1 = true;
                }
                else if (Input.GetButtonDown("VerticalP1") && Input.GetAxisRaw("VerticalP1") < 0 && SPlayer.position != Inode1.position)
                {
                    //Move Bot
                    Debug.Log("Move Bot");
                    FOnIInode1 = false;
                    FPlayer.position = Inode1.position;
                    FOnInode1 = true;
                }
            }
            else if (FOnIInode2)
            {
                if (Input.GetButtonDown("HorizontalP1") && Input.GetAxisRaw("HorizontalP1") > 0 && SPlayer.position != IInode3.position)
                {
                    //Move Right
                    Debug.Log("Move Right");
                    FOnIInode2 = false;
                    FPlayer.position = IInode3.position;
                    FOnIInode3 = true;
                }
                else if (Input.GetButtonDown("HorizontalP1") && Input.GetAxisRaw("HorizontalP1") < 0 && SPlayer.position != IInode1.position)
                {
                    //Move Left
                    FOnIInode2 = false;
                    FPlayer.position = IInode1.position;
                    FOnIInode1 = true;
                }
                else if (Input.GetButtonDown("VerticalP1") && Input.GetAxisRaw("VerticalP1") > 0 && SPlayer.position != IIInode2.position)
                {
                    //Move Top
                    Debug.Log("Move Top");
                    FOnIInode2 = false;
                    FPlayer.position = IIInode2.position;
                    FOnIIInode2 = true;
                }
                else if (Input.GetButtonDown("VerticalP1") && Input.GetAxisRaw("VerticalP1") < 0 && SPlayer.position != Inode2.position)
                {
                    //Move Bot
                    Debug.Log("Move Bot");
                    FOnIInode2 = false;
                    FPlayer.position = Inode2.position;
                    FOnInode2 = true;
                }
            }
            else if (FOnIInode3)
            {
                if (Input.GetButtonDown("HorizontalP1") && Input.GetAxisRaw("HorizontalP1") < 0 && SPlayer.position != IInode2.position)
                {
                    //Move Left
                    Debug.Log("Move Left");
                    FOnIInode3 = false;
                    FPlayer.position = IInode2.position;
                    FOnIInode2 = true;
                }
                else if (Input.GetButtonDown("VerticalP1") && Input.GetAxisRaw("VerticalP1") > 0 && SPlayer.position != IIInode3.position)
                {
                    //Move Top
                    Debug.Log("Move Top");
                    FOnIInode3 = false;
                    FPlayer.position = IIInode3.position;
                    FOnIIInode3 = true;
                }
                else if (Input.GetButtonDown("VerticalP1") && Input.GetAxisRaw("VerticalP1") < 0 && SPlayer.position != Inode3.position)
                {
                    //Move Bot
                    Debug.Log("Move Down");
                    FOnIInode3 = false;
                    FPlayer.position = Inode3.position;
                    FOnInode3 = true;
                }
            }
            else if (FOnIIInode1)
            {
                if (Input.GetButtonDown("HorizontalP1") && Input.GetAxisRaw("HorizontalP1") > 0 && SPlayer.position != IIInode2.position)
                {
                    //Move Right
                    Debug.Log("Move Right");
                    FOnIIInode1 = false;
                    FPlayer.position = IIInode2.position;
                    FOnIIInode2 = true;
                }
                else if (Input.GetButtonDown("VerticalP1") && Input.GetAxisRaw("VerticalP1") < 0 && SPlayer.position != IInode1.position)
                {
                    //Move Down
                    Debug.Log("Move Down");
                    FOnIIInode1 = false;
                    FPlayer.position = IInode1.position;
                    FOnIInode1 = true;
                }
            }
            else if (FOnIIInode2)
            {
                if (Input.GetButtonDown("HorizontalP1") && Input.GetAxisRaw("HorizontalP1") > 0 && SPlayer.position != IIInode3.position)
                {
                    //Move Right
                    Debug.Log("Move Right");
                    FOnIIInode2 = false;
                    FPlayer.position = IIInode3.position;
                    FOnIIInode3 = true;
                }
                else if (Input.GetButtonDown("HorizontalP1") && Input.GetAxisRaw("HorizontalP1") < 0 && SPlayer.position != IIInode1.position)
                {
                    // Move Left
                    Debug.Log("Move Left");
                    FOnIIInode2 = false;
                    FPlayer.position = IIInode1.position;
                    FOnIIInode1 = true;
                }
                else if (Input.GetButtonDown("VerticalP1") && Input.GetAxisRaw("VerticalP1") < 0 && SPlayer.position != IInode2.position)
                {
                    //Move Down
                    Debug.Log("Move Down");
                    FOnIIInode2 = false;
                    FPlayer.position = IInode2.position;
                    FOnIInode2 = true;
                }
            }
            else if (FOnIIInode3)
            {
                if (Input.GetButtonDown("HorizontalP1") && Input.GetAxisRaw("HorizontalP1") < 0 && SPlayer.position != IIInode2.position)
                {
                    // Move to the left
                    Debug.Log("Move Left");
                    FOnIIInode3 = false;
                    FPlayer.position = IIInode2.position;
                    FOnIIInode2 = true;
                }
                else if (Input.GetButtonDown("VerticalP1") && Input.GetAxisRaw("VerticalP1") < 0 && SPlayer.position != IInode3.position)
                {
                    //Move Down
                    Debug.Log("Move Down");
                    FOnIIInode3 = false;
                    FPlayer.position = IInode3.position;
                    FOnIInode3 = true;
                }
            }
            #endregion

            //*********************************************************************************
            //SECOND PLAYER
            #region
            if (SOnInode1)
            {
                if (Input.GetButtonDown("HorizontalP2") && Input.GetAxisRaw("HorizontalP2") > 0 && FPlayer.position != Inode2.position)
                {
                    //Move Right
                    Debug.Log("Move Right");
                    SOnInode1 = false;
                    SPlayer.position = Inode2.position;
                    SOnInode2 = true;

                }
                else if (Input.GetButtonDown("VerticalP2") && Input.GetAxisRaw("VerticalP2") > 0 && FPlayer.position != IInode1.position)
                {
                    //Move Up
                    Debug.Log("Move Up");
                    SOnInode1 = false;
                    SPlayer.position = IInode1.position;
                    SOnIInode1 = true;
                }
            }
            else if (SOnInode2)
            {
                if (Input.GetButtonDown("HorizontalP2") && Input.GetAxisRaw("HorizontalP2") > 0 && FPlayer.position != Inode3.position)
                {
                    //Move Right
                    Debug.Log("Move Right");
                    SOnInode2 = false;
                    SPlayer.position = Inode3.position;
                    SOnInode3 = true;
                }
                else if (Input.GetButtonDown("HorizontalP2") && Input.GetAxisRaw("HorizontalP2") < 0 && FPlayer.position != Inode1.position)
                {
                    //Move Left
                    Debug.Log("Move Left");
                    SOnInode2 = false;
                    SPlayer.position = Inode1.position;
                    SOnInode1 = true;
                }
                else if (Input.GetButtonDown("VerticalP2") && Input.GetAxisRaw("VerticalP2") > 0 && FPlayer.position != IInode2.position)
                {
                    //Move Up
                    Debug.Log("Move Up");
                    SOnInode2 = false;
                    SPlayer.position = IInode2.position;
                    SOnIInode2 = true;
                }
            }
            else if (SOnInode3)
            {
                if (Input.GetButtonDown("HorizontalP2") && Input.GetAxisRaw("HorizontalP2") < 0 && FPlayer.position != Inode2.position)
                {
                    // Move Left
                    Debug.Log("Move Left");
                    SOnInode3 = false;
                    SPlayer.position = Inode2.position;
                    SOnInode2 = true;
                }
                else if (Input.GetButtonDown("VerticalP2") && Input.GetAxisRaw("VerticalP2") > 0 && FPlayer.position != IInode3.position)
                {
                    //Move Up
                    Debug.Log("Move Up");
                    SOnInode3 = false;
                    SPlayer.position = IInode3.position;
                    SOnIInode3 = true;
                }
            }
            else if (SOnIInode1)
            {
                if (Input.GetButtonDown("HorizontalP2") && Input.GetAxisRaw("HorizontalP2") > 0 && FPlayer.position != IInode2.position)
                {
                    //Move Right
                    Debug.Log("Move Right");
                    SOnIInode1 = false;
                    SPlayer.position = IInode2.position;
                    SOnIInode2 = true;
                }
                else if (Input.GetButtonDown("VerticalP2") && Input.GetAxisRaw("VerticalP2") > 0 && FPlayer.position != IIInode1.position)
                {
                    //Move Top
                    Debug.Log("Move Top");
                    SOnIInode1 = false;
                    SPlayer.position = IIInode1.position;
                    SOnIIInode1 = true;
                }
                else if (Input.GetButtonDown("VerticalP2") && Input.GetAxisRaw("VerticalP2") < 0 && FPlayer.position != Inode1.position)
                {
                    //Move Bot
                    Debug.Log("Move Bot");
                    SOnIInode1 = false;
                    SPlayer.position = Inode1.position;
                    SOnInode1 = true;
                }
            }
            else if (SOnIInode2)
            {
                if (Input.GetButtonDown("HorizontalP2") && Input.GetAxisRaw("HorizontalP2") > 0 && FPlayer.position != IInode3.position)
                {
                    //Move Right
                    Debug.Log("Move Right");
                    SOnIInode2 = false;
                    SPlayer.position = IInode3.position;
                    SOnIInode3 = true;
                }
                else if (Input.GetButtonDown("HorizontalP2") && Input.GetAxisRaw("HorizontalP2") < 0 && FPlayer.position != IInode1.position)
                {
                    //Move Left
                    SOnIInode2 = false;
                    SPlayer.position = IInode1.position;
                    SOnIInode1 = true;
                }
                else if (Input.GetButtonDown("VerticalP2") && Input.GetAxisRaw("VerticalP2") > 0 && FPlayer.position != IIInode2.position)
                {
                    //Move Top
                    Debug.Log("Move Top");
                    SOnIInode2 = false;
                    SPlayer.position = IIInode2.position;
                    SOnIIInode2 = true;
                }
                else if (Input.GetButtonDown("VerticalP2") && Input.GetAxisRaw("VerticalP2") < 0 && FPlayer.position != Inode2.position)
                {
                    //Move Bot
                    Debug.Log("Move Bot");
                    SOnIInode2 = false;
                    SPlayer.position = Inode2.position;
                    SOnInode2 = true;
                }
            }
            else if (SOnIInode3)
            {
                if (Input.GetButtonDown("HorizontalP2") && Input.GetAxisRaw("HorizontalP2") < 0 && FPlayer.position != IInode2.position)
                {
                    //Move Left
                    Debug.Log("Move Left");
                    SOnIInode3 = false;
                    SPlayer.position = IInode2.position;
                    SOnIInode2 = true;
                }
                else if (Input.GetButtonDown("VerticalP2") && Input.GetAxisRaw("VerticalP2") > 0 && FPlayer.position != IIInode3.position)
                {
                    //Move Top
                    Debug.Log("Move Top");
                    SOnIInode3 = false;
                    SPlayer.position = IIInode3.position;
                    SOnIIInode3 = true;
                }
                else if (Input.GetButtonDown("VerticalP2") && Input.GetAxisRaw("VerticalP2") < 0 && FPlayer.position != Inode3.position)
                {
                    //Move Bot
                    Debug.Log("Move Down");
                    SOnIInode3 = false;
                    SPlayer.position = Inode3.position;
                    SOnInode3 = true;
                }
            }
            else if (SOnIIInode1)
            {
                if (Input.GetButtonDown("HorizontalP2") && Input.GetAxisRaw("HorizontalP2") > 0 && FPlayer.position != IIInode2.position)
                {
                    //Move Right
                    Debug.Log("Move Right");
                    SOnIIInode1 = false;
                    SPlayer.position = IIInode2.position;
                    SOnIIInode2 = true;
                }
                else if (Input.GetButtonDown("VerticalP2") && Input.GetAxisRaw("VerticalP2") < 0 && FPlayer.position != IInode1.position)
                {
                    //Move Down
                    Debug.Log("Move Down");
                    SOnIIInode1 = false;
                    SPlayer.position = IInode1.position;
                    SOnIInode1 = true;
                }
            }
            else if (SOnIIInode2)
            {
                if (Input.GetButtonDown("HorizontalP2") && Input.GetAxisRaw("HorizontalP2") > 0 && FPlayer.position != IIInode3.position)
                {
                    //Move Right
                    Debug.Log("Move Right");
                    SOnIIInode2 = false;
                    SPlayer.position = IIInode3.position;
                    SOnIIInode3 = true;
                }
                else if (Input.GetButtonDown("HorizontalP2") && Input.GetAxisRaw("HorizontalP2") < 0 && FPlayer.position != IIInode1.position)
                {
                    // Move Left
                    Debug.Log("Move Left");
                    SOnIIInode2 = false;
                    SPlayer.position = IIInode1.position;
                    SOnIIInode1 = true;
                }
                else if (Input.GetButtonDown("VerticalP2") && Input.GetAxisRaw("VerticalP2") < 0 && FPlayer.position != IInode2.position)
                {
                    //Move Down
                    Debug.Log("Move Down");
                    SOnIIInode2 = false;
                    SPlayer.position = IInode2.position;
                    SOnIInode2 = true;
                }
            }
            else if (SOnIIInode3)
            {
                if (Input.GetButtonDown("HorizontalP2") && Input.GetAxisRaw("HorizontalP2") < 0 && FPlayer.position != IIInode2.position)
                {
                    // Move to the left
                    Debug.Log("Move Left");
                    SOnIIInode3 = false;
                    SPlayer.position = IIInode2.position;
                    SOnIIInode2 = true;
                }
                else if (Input.GetButtonDown("VerticalP2") && Input.GetAxisRaw("VerticalP2") < 0 && FPlayer.position != IInode3.position)
                {
                    //Move Down
                    Debug.Log("Move Down");
                    SOnIIInode3 = false;
                    SPlayer.position = IInode3.position;
                    SOnIInode3 = true;
                }
            }
            #endregion
        }
    
}
