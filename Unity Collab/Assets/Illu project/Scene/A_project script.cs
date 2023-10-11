using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody thingDesmond;
    public Renderer transparentObjectRenderer;
    public float transparency = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        /*if (transparentObjectRenderer)
        {
            Color currentColor = transparentObjectRenderer.material.color;
            currentColor.a = transparency;
            transparentObjectRenderer.material.color = currentColor;
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Approximately(transform.position.x, -7.0f))
        {
            thingDesmond.useGravity = true;
            Color currentColor = transparentObjectRenderer.material.color;
            currentColor.a = 1.0f;  // Fully opaque
            transparentObjectRenderer.material.color = currentColor;
        }
    }
}
