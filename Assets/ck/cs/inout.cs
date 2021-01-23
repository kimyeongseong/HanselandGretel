 using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class inout : MonoBehaviour
{
    public float alpha = 255/255;
    public bool b = true;
    void Start()
    {

    }
    void Update()
    {
        if (b == true)
        {
            GetComponent<Image>().color = new Color(255, 255 / 255, 255 / 255, alpha -= 0.01f);
            if (alpha < 0.1f)
            {
                b = false;
            }
        }
        if(b== false)
        {
            GetComponent<Image>().color = new Color(255, 255 / 255, 255 / 255, alpha += 0.01f);
            if(alpha>1.0f)
            {
                b = true;
            }
        }
    }
}