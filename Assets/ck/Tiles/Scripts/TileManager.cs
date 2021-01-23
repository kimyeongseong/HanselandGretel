using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TileManager : MonoBehaviour
{
    [SerializeField]
    public GameObject prefab;
    public GameObject prefab2;
    public GameObject clear;
    public GameObject prefab4;
    public GameObject start;
    public GameObject character;
    public static int a, b, c, d;
    public Text Tile1;
    public Text Tile2;
    public int TileA;
    public int TileB;
    int ai = 0;
    public void Awake()
    {
        Tile1 = GameObject.Find("Text3").GetComponent<Text>();
        Tile2 = GameObject.Find("Text2").GetComponent<Text>();
        //TextManager.TileA = 1;
        //TextManager.TileB = 2;
        Debug.Log(TextManager.TileA);
        Debug.Log(TextManager.TileB);
    }
    public void Start()
    {
        stage1();
    }
    void cookie()
    {
        GameObject tiletype1 = GameObject.Instantiate(prefab);
        tiletype1.transform.SetParent(transform, true);
        //a += 1;
    }
    void cookie2()
    {
        GameObject tiletype2 = GameObject.Instantiate(prefab2);
        tiletype2.transform.SetParent(transform, true);
        //b += 1;
    }
    void clearMake()
    {
        GameObject tiletype2 = GameObject.Instantiate(clear);
        tiletype2.transform.SetParent(transform, true);
        //c += 1;
    }
    void StartMake()
    {
        GameObject tiletype3 = GameObject.Instantiate(start);
        tiletype3.transform.SetParent(transform, true);
        GameObject makecharacter = GameObject.Instantiate(character);
        makecharacter.transform.SetParent(transform.parent, true);
        makecharacter.transform.localPosition=new Vector3 (-330,-330,0);
        //d += 1;
    }
    public void stage1()
    {
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            Debug.Log(SceneManager.GetActiveScene().buildIndex);
            Tile1.text = TextManager.TileA.ToString();
            Tile2.text = TextManager.TileB.ToString();
            cookie2();
            cookie2();
            clearMake();
            cookie();
            cookie();
            cookie2();
            StartMake();
            cookie2();
            cookie();
        }
    }
    public void stage6()
    {
        TextManager.TileA = 2;
        TextManager.TileB = 3;
        cookie();
        cookie2();
        clearMake();
        cookie2();
        cookie();
        cookie2();
        StartMake();
        cookie2();
        cookie2();
    }
    public void stage7()
    {
        TextManager.TileA = 2;
        TextManager.TileB = 2;
        cookie();
        cookie2();
        clearMake();
        cookie2();
        cookie();
        cookie2();
        StartMake();
        cookie2();
        cookie();
    }
    public void stage8()
    {
        TextManager.TileA = 2;
        TextManager.TileB = 3;
        cookie2();
        cookie();
        clearMake();
        cookie2();
        cookie();
        cookie();
        StartMake();
        cookie2();
        cookie2();
    }
    public void stage9()
    {
        TextManager.TileA = 3;
        TextManager.TileB = 2;
        cookie();
        cookie2();
        clearMake();
        cookie2();
        cookie();
        cookie2();
        StartMake();
        cookie();
        cookie();
    }
}
