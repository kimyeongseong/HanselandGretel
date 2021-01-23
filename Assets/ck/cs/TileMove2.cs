using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TileMove2 : MonoBehaviour
{
    [SerializeField]
    private static TileMove2 m_Instance = null;
    public static TileMove2 I
    {
        get
        {
            if (null == m_Instance)
            {
                m_Instance = FindObjectOfType(typeof(TileMove2)) as TileMove2;

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
    public bool i;
    void Start()
    {
        i = false;
    }
    public void OnTriggerEnter(Collider col)
    {
        if ((Tile2.I.m == false && TextManager.TileB >= 0))
        {
            //Debug.Log("hello");
            i = true;
        }
    }

}
