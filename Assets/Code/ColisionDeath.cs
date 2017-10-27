using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionDeath : MonoBehaviour {

    public GameObject deathlts;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            deathlts.SetActive(true);
        }
        
    }
}
