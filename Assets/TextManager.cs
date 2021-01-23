using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextManager : MonoBehaviour
{
    private Transform offset;
    public static Text Tile1;
    public static Text Tile2;
    public static int TileA;
    public static int TileB;
    public float Time = 2.0f;
    public GameObject Fail;
    public GameObject Characterthis;
    public bool Fail2, LeftZero, RightZero;
    public static bool Fail1, Fail5, t, h;

    int i;
    const int MAX = 9;
    private static TextManager m_Instance = null;

    public static TextManager I
    {
        get
        {
            if (null == m_Instance)
            {
                m_Instance = FindObjectOfType(typeof(TextManager)) as TextManager;

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
    void Awake()
    {
        Tile1 = GameObject.Find("Text3").GetComponent<Text>();
        Tile2 = GameObject.Find("Text2").GetComponent<Text>();

    }
    void Start()
    {
        //t = GameObject.Find("left(clone)").GetComponent<Text>();
        //i = 1;
        ////Fail1 = false;
        ////Fail2 = false;
        //LeftZero = false;
        //RightZero = false;

        //TileA = 1;
        //TileB = 2;
        //Debug.Log()
    }
    public void GameFail()
    {
        GameObject tiletype1 = GameObject.Instantiate(Fail);
        tiletype1.transform.SetParent(transform, true);
    }

    public void MoveMoles()
    {
        Fail1 = false;
        Fail5 = false;
        t = false;
        h = false;
        Fail1 = false;
        TileA = 0;
        TileB = 0;
        SceneManager.LoadScene("map");

    }

    public void TileClick1()
    {
        if (t == false)
        {
            TileA -= 1;
            if (TileA <= 0)
            {
                TileA = 0;
                LeftZero = true;
            }
        }
        Tile1.text = TileA.ToString();
    }
    public void TileClick2()
    {
        TileB -= 1;
        if (TileB <= 0)
        {
            TileB = 0;
            RightZero = true;

        }
        Tile2.text = TileB.ToString();
    }
    public void Clear()
    {
        if (Fail1 == true)
        {
            Debug.Log("hello");
            Fail2 = true;
            GameFail();
            Invoke("MoveMoles", Time);
        }
    }
}