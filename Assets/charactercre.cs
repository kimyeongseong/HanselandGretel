using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class charactercre : MonoBehaviour {
    public Image cooldown;
    public bool coolingDown=true;
    public float waitTime = 0.5f;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (coolingDown == true)
        {
            cooldown.fillAmount += 0.5f / waitTime * Time.deltaTime;
        }
    }
}
