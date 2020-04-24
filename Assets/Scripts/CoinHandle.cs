using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinHandle : MonoBehaviour
{
    public Sprite[] spriteList;
    private int index;
    public Image image;
    private int fixedUpdateCounter=0;
    private int offset=0;

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
    // Start is called before the first frame update
    void Start()
    {
        reload("coin");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        fixedUpdateCounter++;
        if (fixedUpdateCounter % 10 == 0)
        {
            //換圖
            index++;
            if (index >= 15)
            {
                index = 0;
            }

            image.sprite = spriteList[index + offset];
        }
    }
}
