using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public ResourceManager stats;
    public Slider HPBar;
    public Text HPText;
    public Slider MPBar;
    public Text MPText;
    public Text sKeyQ;
    

    // Start is called before the first frame update
    void Start()
    {
        //move to update later when experience/levels are implemented.
        HPBar.maxValue = stats.maxHP;
        MPBar.maxValue = stats.maxMP;
    }

    // Update is called once per frame
    void Update()
    {
        HPBar.value = stats.currentHP;
        HPText.text = "HP: " + stats.currentHP + "/" + stats.maxHP;
        MPBar.value = stats.currentMP;
        MPText.text = "MP: " + stats.currentMP + "/" + stats.maxMP;
        sKeyQ.text = "" + stats.sKeys;
    }
}
