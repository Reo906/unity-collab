using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody thingDesmond;
    public Renderer transparentObjectRenderer;
    public Renderer secondObjectRenderer;
    public float transparency = 1.0f;
    private float timeAtPosition = 0f;
    private const float requiredTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Approximately(transform.position.x, -7.0f) && Mathf.Approximately(transform.position.z, -5.0f))
        {
            timeAtPosition += Time.deltaTime;

            if (timeAtPosition >= requiredTime)
            {
                thingDesmond.useGravity = true;
                ApplyChanges();
                timeAtPosition = 0f;
            }
        }
        else
        {
            timeAtPosition = 0f;
        }
    }

    private void ApplyChanges()
    {
        if (transparentObjectRenderer)
        {
            Color currentColor = transparentObjectRenderer.material.color;
            currentColor.a = 1.0f;  // Fully opaque
            transparentObjectRenderer.material.color = currentColor;
        }

        if (secondObjectRenderer)
        {
            Color currentColor = secondObjectRenderer.material.color;
            currentColor.a = 0.0f;  // Fully transparent
            secondObjectRenderer.material.color = currentColor;
        }
    }
}
