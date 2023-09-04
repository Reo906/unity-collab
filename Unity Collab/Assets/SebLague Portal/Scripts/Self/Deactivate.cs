using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivate : MonoBehaviour
{
    public GameObject Activate_object;
    public GameObject Deactivate_object;
    public GameObject Activate_linked;
    public GameObject Deactivate_linked;

    private void Start()
    {
        Activate_object.SetActive(false);
        Activate_linked.SetActive(false);

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            Activate_object.SetActive(true);
            Activate_linked.SetActive(true);
            Deactivate_object.SetActive(false);
            Deactivate_linked.SetActive(false);

        }
    
    }
}
