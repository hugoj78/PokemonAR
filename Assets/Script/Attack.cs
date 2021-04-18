using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{
    public Animator anim;

    public GameObject yourButton;
 
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        
    }

    private void TaskOnClick()
    {
        anim.SetTrigger("Active");
    }
}
