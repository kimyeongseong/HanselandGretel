using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TileManager2 : MonoBehaviour
{
    [SerializeField]
    public GameObject prefab;
    public GameObject prefab2;
    public GameObject clear;
    public GameObject prefab4;
    public GameObject start;
    public GameObject character;
    //public static int a, b, c, d;
    public Text Tile1;
    public Text Tile2;
    public int TileA;
    public int TileB;
    int ai = 0;
    public void Awake()
    {
        Tile1 = GameObject.Find("Text3").GetComponent<Text>();
        Tile2 = GameObject.Find("Text2").GetComponent<Text>();
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {

            TextManager.TileA = 1;
            TextManager.TileB = 2;
        }
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            Debug.Log("stage2");
            TextManager.TileA = 2;
            TextManager.TileB = 1;
        }
        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            Debug.Log("stage3");
            TextManager.TileA = 1;
            TextManager.TileB = 2;
        }
        if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            Debug.Log("stage4");
            TextManager.TileA = 2;
            TextManager.TileB = 1;
        }
        if (SceneManager.GetActiveScene().buildIndex == 7)
        {
            Debug.Log("stage5");
            TextManager.TileA = 3;
            TextManager.TileB = 2;
        }
        if (SceneManager.GetActiveScene().buildIndex == 8)
        {
            Debug.Log("stage6");
            TextManager.TileA = 2;
            TextManager.TileB = 3;
        }
        if (SceneManager.GetActiveScene().buildIndex ==9)
        {
            Debug.Log("stage7");
            TextManager.TileA = 2;
            TextManager.TileB = 2;
        }
        if (SceneManager.GetActiveScene().buildIndex == 10)
        {
            Debug.Log("stage8");
            TextManager.TileA = 2;
            TextManager.TileB = 3;
        }
        if (SceneManager.GetActiveScene().buildIndex == 11)
        {
            Debug.Log("stage9");
            TextManager.TileA = 3;
            TextManager.TileB = 2;
        }
        if (SceneManager.GetActiveScene().buildIndex == 12)
        {
            Debug.Log("stage10");
            TextManager.TileA = 3;
            TextManager.TileB = 3;
        }
        if (SceneManager.GetActiveScene().buildIndex == 13)
        {
            Debug.Log("stage11");
            TextManager.TileA = 1;
            TextManager.TileB = 5;
        }
    }
    public void Start()
    {
        stage2();
    }
    void cookie()
    {
        GameObject tiletype1 = Instantiate(prefab);
        tiletype1.transform.SetParent(transform, true);
        //a += 1;
    }
    void cookie2()
    {
        GameObject tiletype2 = Instantiate(prefab2);
        tiletype2.transform.SetParent(transform, true);
        //b += 1;
    }
    void clearMake()
    {
        GameObject tiletype2 = Instantiate(clear);
        tiletype2.transform.SetParent(transform, true);
        //c += 1;
    }
    void StartMake()
    {
        GameObject tiletype3 = Instantiate(start);
        tiletype3.transform.SetParent(transform, true);
        GameObject makecharacter = GameObject.Instantiate(character);
        makecharacter.transform.SetParent(transform.parent, true);
        makecharacter.transform.localPosition = new Vector3(-330, -330, 0);

        //d += 1;
    }
    public void stage2()
    {
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
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
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            Debug.Log("stage2");
            Tile1.text = TextManager.TileA.ToString();
            Tile2.text = TextManager.TileB.ToString();
            cookie();
            cookie();
            clearMake();
            cookie2();
            cookie2();
            cookie();
            StartMake();
            cookie();
            cookie2();
        }
        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            Debug.Log("stage3");
            Tile1.text = TextManager.TileA.ToString();
            Tile2.text = TextManager.TileB.ToString();
            cookie();
            cookie2();
            clearMake();
            cookie2();
            cookie2();
            cookie();
            StartMake();
            cookie();
            cookie2();
        }
        if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            Debug.Log("stage4");
            Tile1.text = TextManager.TileA.ToString();
            Tile2.text = TextManager.TileB.ToString();
            cookie();
            cookie2();
            clearMake();
            cookie2();
            cookie2();
            cookie();
            StartMake();
            cookie();
            cookie2();
        }
        if (SceneManager.GetActiveScene().buildIndex == 7)
        {
            Debug.Log("stage5");
            Tile1.text = TextManager.TileA.ToString();
            Tile2.text = TextManager.TileB.ToString();
            cookie2();
            cookie();
            clearMake();
            cookie();
            cookie2();
            cookie();
            StartMake();
            cookie();
            cookie2();
        }
        if (SceneManager.GetActiveScene().buildIndex == 8)
        {
            Debug.Log("stage6");
            Tile1.text = TextManager.TileA.ToString();
            Tile2.text = TextManager.TileB.ToString();
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
        if (SceneManager.GetActiveScene().buildIndex == 9)
        {
            Debug.Log("stage7");
            Tile1.text = TextManager.TileA.ToString();
            Tile2.text = TextManager.TileB.ToString();
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
        if (SceneManager.GetActiveScene().buildIndex == 10)
        {
            Debug.Log("stage8");
            Tile1.text = TextManager.TileA.ToString();
            Tile2.text = TextManager.TileB.ToString();
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
        if (SceneManager.GetActiveScene().buildIndex == 11)
        {
            Debug.Log("stage9");
            Tile1.text = TextManager.TileA.ToString();
            Tile2.text = TextManager.TileB.ToString();
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
        if (SceneManager.GetActiveScene().buildIndex == 12)
        {
            Debug.Log("stage10");
            Tile1.text = TextManager.TileA.ToString();
            Tile2.text = TextManager.TileB.ToString();
            cookie();
            cookie2();
            cookie();
            cookie2();
            cookie2();
            cookie2();
            StartMake();
            cookie();
            clearMake();
        }
        if (SceneManager.GetActiveScene().buildIndex == 13)
        {
            Debug.Log("stage11");
            Tile1.text = TextManager.TileA.ToString();
            Tile2.text = TextManager.TileB.ToString();
            cookie();
            cookie2();
            cookie();
            cookie2();
            cookie2();
            cookie2();
            StartMake();
            cookie();
            clearMake();
        }
    }
}