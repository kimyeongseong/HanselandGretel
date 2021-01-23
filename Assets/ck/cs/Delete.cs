using UnityEngine;
using System.Collections;

public class Delete : MonoBehaviour {
    public GameObject DelObject;
    //GameObject popup = GameObject.FindGameObjectWithTag("popup");

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void PopUpDel()
    {
        Destroy(gameObject);
    }



}
