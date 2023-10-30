using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateMaximum : MonoBehaviour
{

    public int a = 1;
    public int b = 2;
    public int Højeste;



    // Start is called before the first frame update
    void Start()
    {
        Højeste = CalculateMax(a, b);
        Debug.LogFormat("Det højeste er " + Højeste);
        int Laveste = CalculateMin(a, b);
        Debug.LogFormat("Det laveste er " + Laveste);
        CalculateLige(a, b);
        FindPartyMembers(0, "Oskar Kaare");
    }
    public void FindPartyMembers(int index, string name) //read what olga wrote
    {
        List<string> QuestPartyMembers = new List<string>()
        {
            "Jason Derulo",
            "Bernie Sanders",
            "Barack Obama"
        };
       
        QuestPartyMembers.Insert(0, name);
        int listLength = QuestPartyMembers.Count;
        Debug.LogFormat("Party Members: {0}", listLength);
        for (int i = 0; i < listLength; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i,
            QuestPartyMembers[i]);


        }

    }




    public int CalculateMax(int n, int m)
    {
        if (n > m)
        {
            return n;
        }

        else
        {
            return m;
        }
    }
    public int CalculateMin(int c, int d)
    {
        if (c < d)
        {
            return c;
        }

        else
        {
            return d;
        }
    }
    public void CalculateLige(int e, int f)
    {
        if (e == f)
        {
            Debug.Log("Tallene er lige");
        }
        else
        {
            Debug.Log("Tallene er IKKE lige");
        }
       
    }

    // Update is called once per frame
    void Update()
    {

    }

}