using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vb_change : MonoBehaviour
{

    public GameObject dragon1, dragon2;   

    public Button yourButton;

	void Start () {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		Debug.Log ("You have clicked the button!");
        VirtualButtonChange();
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
