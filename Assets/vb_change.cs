using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_change : MonoBehaviour
{

    public GameObject vbBtnObj, dragon1, dragon2;   
 

    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("colorButton");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        VirtualButtonChange();
        Debug.Log("Button pressed");
    }
 
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button released");
    }

    void VirtualButtonChange()
    {
        if (dragon1.activeInHierarchy)
        {
            dragon1.SetActive(false);
            dragon2.SetActive(true);
        }
        else
        {
            dragon1.SetActive(true);
            dragon2.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
