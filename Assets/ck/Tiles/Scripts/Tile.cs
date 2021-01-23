using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System;

public class Tile : MonoBehaviour, IPointerDownHandler
{
    [SerializeField]
    private Transform offset;
    public int i;
    public bool hello = false;
    public bool j;
    public bool Fail1, Fail2, LeftZero, RightZero;
    public float Time = 2.0f;
    public GameObject Fail;
    public bool P;/*= a.GetComponent<Tile2>();*/
    bool h = false;

    private static Tile m_Instance = null;
    public static Tile I
    {
        get
        {
            if (null == m_Instance)
            {
                m_Instance = FindObjectOfType(typeof(Tile)) as Tile;

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

        //P = a.GetComponent<Tile2>().RightZero;
        //script = GameObject.Find("Tile Grid").GetComponent<TileManager>();
    }
    void Update()
    {
        if ((TextManager.Fail1 == true || TextManager.Fail5 == true) && TextManager.h == false)
        {
            TextManager.h = true;
            TextManager.I.Clear();
        }
    }
    public void CharaterMove()
    {
        Character.Instance.transform.position = offset.position;
    }
    public void GameFail()
    {
        GameObject tiletype1 = Instantiate(Fail);
        tiletype1.transform.SetParent(transform, true);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        float distance = Vector3.Distance(offset.transform.position, Character.Instance.transform.position);
        if (distance <= 353 )
        {
            //Debug.LogError(TextManager.Fail1);
            if (j == false && TextManager.TileA > 0)
            {
                CharaterMove();
                TextManager.I.TileClick1();
                j = true;
                GetComponent<AudioSource>().Play();
            }
            else if (j == true)
            {
                CharaterMove();
            }

            if (TextManager.TileA <= 0 && TextManager.TileB <= 0 && j == false)
            {
                TextManager.Fail1 = true;
            }

            //Debug.Log(Fail2);
            //Fail1 = false;
        }
    }

}