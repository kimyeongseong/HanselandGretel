using UnityEngine;
using System.Collections;

public class die : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnTriggerEnter(Collider col)
    {
       
            GameObject.FindGameObjectWithTag("die").transform.localPosition = new Vector3(0, 0, 0);
    }

}
