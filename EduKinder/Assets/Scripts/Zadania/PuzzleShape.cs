using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleShape : GameManager
{
    //Puzzle Pieces
    [Header("Puzzle shape")]
    public GameObject s1;
    public GameObject s2, s3, s4;

    //Puzzle Field drop
    [Header("Puzzle field drop")]
    public GameObject f1;
    public GameObject f2, f3, f4;

    //Puzzle Field drop
    [Header("Distanse mistake drop")]
    public short distansemistake;

    Vector2 s1InitialPos, s2InitialPos, s3InitialPos, s4InitialPos;
    bool s1Correct, s2Correct, s3Correct, s4Correct = false;


    // Start is called before the first frame update
    void Start()
    {
        s1InitialPos = s1.transform.position;
        s2InitialPos = s2.transform.position;
        s3InitialPos = s3.transform.position;
        s4InitialPos = s4.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (s1Correct && s2Correct && s3Correct && s4Correct)
        {
            CloudText("Brawo udało Ci się poprawnie dopasować kształty");
            GameObject.Find("MainMenu/Btn_Back").GetComponent<Animation>().Play("Btn_Attention");
        }
    }


    //Drag()
    public void Drags1()
    {
        s1.transform.position = Input.mousePosition;
    }
    public void Drags2()
    {
        s2.transform.position = Input.mousePosition;
    }
    public void Drags3()
    {
        s3.transform.position = Input.mousePosition;
    }
    public void Drags4()
    {
        s4.transform.position = Input.mousePosition;
    }

    //Drop
    public void Drops1()
    {
        float Distance = Vector3.Distance(s1.transform.position, f1.transform.position);
        if (Distance < distansemistake)
        {
            s1.transform.position = f1.transform.position;
            s1Correct = true;
        }
        else
        {
            s1.transform.position = s1InitialPos;
            s1Correct = false;
        }
    }

    public void Drops2()
    {
        float Distance = Vector3.Distance(s2.transform.position, f2.transform.position);
        if (Distance < distansemistake)
        {
            s2.transform.position = f2.transform.position;
            s2Correct = true;
        }
        else
        {
            s2.transform.position = s2InitialPos;
            s2Correct = false;
        }
    }
    public void Drops3()
    {
        float Distance = Vector3.Distance(s3.transform.position, f3.transform.position);
        if (Distance < distansemistake)
        {
            s3.transform.position = f3.transform.position;
            s3Correct = true;
        }
        else
        {
            s3.transform.position = s3InitialPos;
            s3Correct = false;
        }
    }
    public void Drops4()
    {
        float Distance = Vector3.Distance(s4.transform.position, f4.transform.position);
        if (Distance < distansemistake)
        {
            s4.transform.position = f4.transform.position;
            s4Correct = true;
        }
        else
        {
            s4.transform.position = s4InitialPos;
            s4Correct = false;
        }
    }
}
