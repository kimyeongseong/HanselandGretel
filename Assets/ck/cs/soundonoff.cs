using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class soundonoff : MonoBehaviour {
    public Image img;
    public UnityEngine.UI.Button btn;
    public bool disableonstart = true;
	void Start () {
 
        img.fillAmount = 0.5f;
        if (img==null)
        img = gameObject.GetComponent<Image>();
        if (btn == null)
            btn = gameObject.GetComponent<UnityEngine.UI.Button>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void sound1onoff()
    {
        if (disableonstart == false)
        {
            disableonstart = true;
        }
        else if (disableonstart == true)
        {
            
        } 
    }
}
