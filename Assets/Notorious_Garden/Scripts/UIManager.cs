using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreEctoplasm;
    
    void Start()
    {

    }

    public void UpdateEctoplasm(){
        Player.instance.score += 0.001;
        scoreEctoplasm.text = "Ectoplasm: " + ((int)Player.instance.score).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateEctoplasm();
        
    }
}
