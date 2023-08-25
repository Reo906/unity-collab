using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_invisible : MonoBehaviour
{
    public GameObject Portal;
    public GameObject linkedPortal;
    bool destroy = false;

    void OnTriggerEnter(Collider other)
    {
        destroy = true;
    }

    void OnBecameInvisible()
    {
        if (destroy)
        {
            linkedPortal.SetActive(false);
            Portal.SetActive(false);
        }
    }

}
