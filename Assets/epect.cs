using UnityEngine;
using System.Collections;

public class epect : MonoBehaviour
{

    public GameObject Pause;
    public Transform Parent;
    public float a;
    public float b;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClick()
    {
        Parent = this.transform;
        GameObject Pause1 = GameObject.Instantiate(Pause);
        Pause1.transform.parent = Parent;
        Pause1.transform.localPosition = Vector3.zero;
        Pause1.transform.localScale = new Vector3(10, 10, 10);
    }
}
