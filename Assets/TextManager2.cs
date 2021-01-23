using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextManager2 : MonoBehaviour
{
    private Transform offset;
    public static Text Tile1;
    public static Text Tile2;
    public static int TileA;
    public static int TileB;
    public float Time = 2.0f;
    public GameObject Fail;
    public static Vector3[] arr3D;
    public GameObject Characterthis;
    public bool Fail1, Fail2, LeftZero, RightZero;
    int i;
    const int MAX = 9;
    private static TextManager2 m_Instance = null;

    public static TextManager2 I
    {
        get
        {
            if (null == m_Instance)
            {
                m_Instance = FindObjectOfType(typeof(TextManager2)) as TextManager2;

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
        arr3D = new Vector3[MAX];
    }
    void Start()
    {
        i = 1;
        Fail1 = false;
        Fail2 = false;
        LeftZero = false;
        RightZero = false;
        //TileA = 2;
        //TileB = 1;
        Tile1.text = TileA.ToString();
        Tile2.text = TileB.ToString();
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

    public void TileClick1()
    {
        Debug.Log(Tile.I.j);
        Debug.Log("Click");
        if (Tile.I.j == false)
        {
            TileA -= 1;
            if (TileA <= 0)
            {
                TileA = 0;
                LeftZero = true;
                if ((TileB <= 0 && TileA <= 0) && Fail1 == true)
                {
                    Debug.Log("hello");
                    Fail2 = true;
                    GameFail();
                    Invoke("MoveMoles", Time);
                }
                else if (TileB <= 0 && TileA <= 0)
                {
                    Fail1 = true;
                }
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
            if ((TileB <= 0 && TileA <= 0) && Fail1 == true)
            {
                Debug.Log("hello");
                Fail2 = true;
                Tile.I.hello = true;
                GameFail();
                Invoke("MoveMoles", Time);

            }
            else if (TileB <= 0 && TileA <= 0)
            {
                Fail1 = true;
            }
        }
        Tile2.text = TileB.ToString();
    }
}