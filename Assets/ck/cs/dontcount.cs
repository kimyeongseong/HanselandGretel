using UnityEngine;

using System.Collections;

public class aicube_creator : MonoBehaviour
{
    public GameObject targetBox;
    public GameObject startPos;

    private GameObject[] tmpbox = new GameObject[] { };

    void OnGUI()
    {

        //박스 생성할 버튼

        if (GUI.Button(new Rect(0f, 0f, 100f, 50f), "Click"))
        {



            // 임시 오브젝트를 만들고

            GameObject prefBox;



            // 박스를 만든다.

            prefBox = Instantiate(targetBox, startPos.transform.position, Quaternion.identity) as GameObject;
        }
    }
}