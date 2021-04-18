using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health2 : MonoBehaviour
{
    [SerializeField]
    private int maxHealth = 100;

    private int currentHealth;

    public GameObject buttonAttaque, buttonReset;

    public Animator anim;

    public event Action<float> OnHealthPctChanged = delegate { };

    void Start () {
		Button btn = buttonAttaque.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);

        Button btnReset = buttonReset.GetComponent<Button>();
		btnReset.onClick.AddListener(TaskResetOnClick);
	}

    void OnEnable()
    {
        currentHealth = maxHealth;
        buttonReset.SetActive(false);
    }

    public void ModifyHealth(int amount) {
        currentHealth += amount;

        float currentHealthPct = (float)currentHealth / (float)maxHealth;
        OnHealthPctChanged(currentHealthPct);
    }

    void TaskOnClick(){
        if(currentHealth - 10 >= 0 ) {
            ModifyHealth(-10);
        } else {
            anim.SetBool("Dead", true);
            buttonReset.SetActive(true);
        }
    }

    void TaskResetOnClick() {
        currentHealth = maxHealth;
        ModifyHealth(0);
        anim.SetBool("Dead", false);
        buttonReset.SetActive(false);
    }

}
