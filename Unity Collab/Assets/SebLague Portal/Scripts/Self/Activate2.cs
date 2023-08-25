using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate2 : MonoBehaviour
{
    public GameObject target;
    void OnTriggerEnter(Collider other)
    {
        if (target.activeInHierarchy)
        {
            target.SetActive(false);
        }
        else
        {
            target.SetActive(true);
        }
    }
}
