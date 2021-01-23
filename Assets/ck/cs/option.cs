using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class option : MonoBehaviour {
    public float a=0.0f;
    private float TimeLeft = 0.005f;
    private float nextTime = 0.0f;
    public GameObject Pause;
    public Transform Parent;
    void Start () {
    }
	
	void Update () {
        if (Time.time > nextTime && a <= 1.0f)
        {
            nextTime = Time.time + TimeLeft;
            MoveMoles();
        }
    }
    public void OptionCret()
    {
        Parent = this.transform;

        GameObject Pause1 = GameObject.Instantiate(Pause);
        Pause1.transform.parent = Parent.parent;
        Pause1.transform.localPosition=new Vector3(0,2,0);
        Pause1.transform.localScale = Vector3.one;
    }
    void MoveMoles()
    {
        a += 0.1f;
    }


}
