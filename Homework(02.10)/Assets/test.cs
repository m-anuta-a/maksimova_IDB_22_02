using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CUBE;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickButton()
    {
        if (CUBE.activeSelf)
        {
            CUBE.SetActive(false);
        }
        else
        {
            CUBE.SetActive(true);
        }
    }
}
