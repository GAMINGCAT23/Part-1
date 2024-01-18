using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject Door;
    public GameObject DoorPrefab;
    public Transform DoorP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Door != false) { Door.SetActive(false);
        }
        else { Door.SetActive(true);}
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
