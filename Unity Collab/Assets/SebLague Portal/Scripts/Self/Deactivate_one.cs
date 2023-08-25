using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivate_one : MonoBehaviour
{
    public GameObject Portal;
    public GameObject LinkedPortal;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        Portal.SetActive(false);
        LinkedPortal.SetActive(false);
    }
}
