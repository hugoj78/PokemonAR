using UnityEngine;
using UnityEngine.Events;
using Vuforia;
 
public class buttonChange : MonoBehaviour
{
 
    public GameObject vbBtnObj, dragon1, dragon2;
 
    // Use this for initialization
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
}

