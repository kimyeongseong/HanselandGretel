using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;
public class tile3 : MonoBehaviour, IPointerDownHandler
{
    [SerializeField]
    private Transform offset;
    public int i;
    bool hello, hello2 = false;
       private static tile3 m_Instance = null;

    public static tile3 I
    {
        get
        {
            if (null == m_Instance)
            {
                m_Instance = FindObjectOfType(typeof(tile3)) as tile3;

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
    public void OnPointerDown(PointerEventData eventData)
    {
        float distance = Vector3.Distance(offset.transform.position, Character.Instance.transform.position);
        if (distance <= 353)
        {
            if (TextManager.I.Fail2 == false)
            {
                CharaterMove();
            }
        }
    }
}