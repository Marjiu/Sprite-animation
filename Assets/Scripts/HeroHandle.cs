﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroHandle : MonoBehaviour
{
    public Image image;
    public Sprite[] spriteList;
    private int index;
    private int offset; 
    private int fixedUpdateCounter = 0; //計算時間
    public bool reload(string name)
    {
        bool result = false;
        try
        {
            string path = $@"Sprites\{name}";
            spriteList = Resources.LoadAll<Sprite>(path);

            index = 0;
        }
        catch (System.Exception exp)
        {
            Debug.LogError(exp.ToString());
            throw;
        }
        return result;
    }
    void Start()
    {
        reload("link_sprite_sheet");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            offset = 30;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            offset = 10;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            offset = 20;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            offset = 40;
        }
    }

    private void FixedUpdate()
    {
        fixedUpdateCounter++;
        if (fixedUpdateCounter % 10 == 0)
        {
            //換圖
            index++;
            if (index >= 9)
            {
                index = 0;
            }

            image.sprite = spriteList[index + offset];
        }
    }

}