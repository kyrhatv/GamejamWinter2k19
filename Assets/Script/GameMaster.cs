﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    [SerializeField]
    public Text week, intel, cardio, strenght, dance;

    public int Week, Intel, Cardio, Strenght, Dance;

    void Start()
    {
        Week = 2;
        week.text = Week.ToString();
        
    }

    
    void Update()
    {
        
    }

    public void ajouterStat(int intel, int cardio, int strenght, int dance)
    {
        Intel += intel;
        Cardio += cardio;
        Strenght += strenght;
        Dance += dance;
    }
}
