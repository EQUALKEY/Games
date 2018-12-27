﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ME_NumButton : MonoBehaviour {

    public GameObject EC;
    private MapEditorEC eccs;

    public GameObject Cover;

    private int thisNum;

    private void Awake()
    {
        eccs = EC.GetComponent<MapEditorEC>();
        thisNum = this.name[0]-'0';
    }

    public void ClickUpAsButton()
    {

        eccs.Clear_Num();
        eccs.Overlay.SetActive(false);
        eccs.Direction_Button.SetActive(false);
        eccs.Num = thisNum;
        Cover.SetActive(true);

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Initialize()
    {
        Cover.SetActive(false);
    }
}