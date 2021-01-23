using UnityEngine;
using System.Collections;

public class onoff : MonoBehaviour {

    public void Open() { gameObject.SetActive(true); }
    public void Close() { gameObject.SetActive(false); }

    public void exit()
    {
        Application.Quit();
    }

}


