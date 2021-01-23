using UnityEngine;
using UnityEngine.EventSystems;

class Character : MonoBehaviour
{
    [SerializeField]
    public static Character Instance { get; private set; }

    //public GameObject effect;
    private TileManager script;
    public static int a = TileManager.a;
    //public static Transform pos;
    private static Character m_Instance = null;

    public static Character J
    {
        get
        {
            if (null == m_Instance)
            {
                m_Instance = FindObjectOfType(typeof(Character)) as Character;

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
        Instance = this;
    }

}

