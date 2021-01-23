using UnityEngine;
using System.Collections;

public class moveimahetile : MonoBehaviour
{
    bool postrue = true;
    public float y = -1300;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if(y<=0)
        {
            y += 70;
        }
        
            transform.localPosition = new Vector3(0, y, 0);
        if(transform.localPosition.y>=0)
        {
            transform.localPosition = new Vector3(0, 0, 0);
        }
    }
}
