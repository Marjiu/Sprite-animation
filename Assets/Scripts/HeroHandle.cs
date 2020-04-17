using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroHandle : MonoBehaviour
{
    public Sprite[] sprites;
    private int index = 0;
    public Image HeroImg;
    private void FixedUpdate()
    {
        index++;
        if (index >= sprites.Length)
            index = 0;

    }
}
