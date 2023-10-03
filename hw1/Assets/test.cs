using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject CUBE;
    
    // Start is called before the first frame update
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
