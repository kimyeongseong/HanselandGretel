using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TileMove1 : MonoBehaviour
{
    [SerializeField]
    private static TileMove1 m_Instance = null;
    public static TileMove1 I
    {
        get
        {
            if (null == m_Instance)
            {
                m_Instance = FindObjectOfType(typeof(TileMove1)) as TileMove1;

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
        if (Tile.I.j == false && TextManager.TileA >= 0)
        {
            i = true;
        }
    }
}