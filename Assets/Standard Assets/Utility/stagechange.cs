using UnityEngine;
using System.Collections;

public class stagechange : MonoBehaviour {

    public Sprite CurrentSprite;
    public Sprite NextSprite;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = CurrentSprite;
    }


    void Update()
    {
        if (true)
        {
            //spriteRenderer.sprite = NextSprite;
        }
    }

}
