using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;
using UnityEngine.SceneManagement;
public class Tile2 : MonoBehaviour, IPointerDownHandler
{
    [SerializeField]
    private Transform offset;
    public int i;
    public bool hello = false;
    public bool m= false;
    public GameObject Fail;
    public bool Fail1, Fail2, LeftZero, RightZero;
    public float Time = 2.0f;
    private static Tile2 m_Instance = null;
    public static Tile2 I
    {
        get
        {
            if (null == m_Instance)
            {
                m_Instance = FindObjectOfType(typeof(Tile2)) as Tile2;

                if (null == m_Instance)
                {
#if _debug
                    Debug.Log("Fail to get Manager Instance [CSystemMng.cs]");
#endif
                    return null;
                }
            }
            return m_Instance;
        }
    }
    void Start()
    {
        //script = GameObject.Find("Tile Grid").GetComponent<TileManager>();
    }
    public void CharaterMove()
    {
        Character.Instance.transform.position = offset.position;
    }
    public void GameFail()
    {
        GameObject tiletype1 = GameObject.Instantiate(Fail);
        tiletype1.transform.SetParent(transform, true);
    }
    public void MoveMoles()
    {
        SceneManager.LoadScene("map");
    }
    void Update()
    {
        if ((TextManager.Fail1 == true || TextManager.Fail5 == true) && TextManager.h == false)
        {
            TextManager.h = true;
            TextManager.I.Clear();
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        //float distance = Vector3.Distance(offset.transform.position, Character.Instance.transform.position);
        //if (distance <= 353)
        //{
        //    if (m == false && TextManager.TileB > 0 )
        //    {
        //        CharaterMove();
        //        Debug.Log("righton");
        //        TextManager.I.TileClick2();
        //        m = true;
        //        GetComponent<AudioSource>().Play();
        //        if(TextManager.TileB<=0)
        //        {
        //            RightZero = true;
        //        }

        //    }
        //    else if (m == true && TextManager.I.Fail2 == false)
        //    {
        //        CharaterMove();
        //        Debug.Log("itrue on");
        //    }

        //    else if (TextManager.Fail1 == true)
        //    {
        //        GameFail();
        //        Invoke("MoveMoles", Time);
        //    }
        //    else if (TextManager.TileA <= 0 && TextManager.TileB <= 0)
        //    {
        //        TextManager.Fail1 = true;
        //    }
        //    //Debug.Log(Fail2);
        //    //Fail1 = false;
        //}
        float distance = Vector3.Distance(offset.transform.position, Character.Instance.transform.position);
        if (distance <= 353)
        {
            //Debug.LogError(TextManager.Fail1);
            if (m == false && TextManager.TileB > 0)
            {
                CharaterMove();
                TextManager.I.TileClick2();
                m = true;
                GetComponent<AudioSource>().Play();
            }
            else if (m == true)
            {
                CharaterMove();
            }
            if (TextManager.TileA <= 0 && TextManager.TileB <= 0&&m==false)
            {
                TextManager.Fail1 = true;
            }
            //TextManager.I.Clear();

            //Debug.Log(Fail2);
            //Fail1 = false;
        }
    }
}