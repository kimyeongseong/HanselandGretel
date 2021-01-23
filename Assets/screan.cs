using UnityEngine;
using System.Collections;

public class screan : MonoBehaviour {
    void Awake()
    {
        Debug.Log("720*1280");
        Screen.SetResolution(1080, 1920,true);
    }
        // Use this for initialization
        void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
