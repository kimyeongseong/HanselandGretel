using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class sound : MonoBehaviour
{
    AudioSource getaudio;
    public bool onoff = false;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        

    }
    public void sounfonoff()
    {
        //getaudio.mute = onoff;
        if(onoff==false)
        {
            onoff = true;
            transform.localPosition = new Vector3(-25, 0, 0);
            gameObject.GetComponent<AudioSource>().Pause();
        }

        else if (onoff==true)
        {
            onoff = false;
            transform.localPosition = new Vector3(25, 0, 0);
            gameObject.GetComponent<AudioSource>().UnPause();

        }

    }
}
