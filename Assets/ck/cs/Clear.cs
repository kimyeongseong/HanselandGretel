using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Clear : MonoBehaviour
{
    [SerializeField]
    public GameObject clearpop;
    public RuntimeAnimatorController ca;
    public Animation anim;
    public GameObject b;
    public GameObject a;
    public float hello = 0.7f;
    void Start()
    {
        
    }
    public void MoveMoles()
    {
        TextManager.Fail1 = false;
        TextManager.Fail5 = false;
        TextManager.t = false;
        TextManager.h = false;
        TextManager.Fail1 = false;
        TextManager.TileA = 0;
        TextManager.TileB = 0;
        SceneManager.LoadScene("map");
    }

    public void OnTriggerEnter(Collider col)
    {
        if (TextManager.TileA == 0 && TextManager.TileB == 0)
        {
            GameObject tiletype1 = Instantiate(clearpop);
            tiletype1.transform.SetParent(transform, true);
            Invoke("MoveMoles", hello);
        }
        else
        {
            TextManager.I.GameFail();
            Invoke("MoveMoles", hello);
        }


    }

}