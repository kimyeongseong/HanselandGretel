using UnityEngine;
using System.Collections;

public class Singleton : MonoBehaviour
{
    private static Singleton instance;
    public float a=100;
    public static Singleton GetInstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType(typeof(Singleton)) as Singleton;
            }

            if (instance == null)
            {
                GameObject obj = new GameObject("obj");
                instance = obj.AddComponent(typeof(Singleton)) as Singleton;
            }
            return instance;
        }
    }

    public int m_data { set; get; }
}