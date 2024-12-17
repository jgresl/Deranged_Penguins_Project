using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Paths : MonoBehaviour

    
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (button1.activeSelf && button2.activeSelf && button3.activeSelf) {
            button4.SetActive(true);
        }
    }
}
