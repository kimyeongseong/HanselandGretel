using UnityEngine;
using System.Collections;

public class timedel : MonoBehaviour {
    public float hello = 1.0f;
    void Start()    
    {
        Invoke("MoveMoles", hello);
    }
    public void MoveMoles()
    {
        Destroy(gameObject);
    }
}
