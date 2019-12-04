using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class TalentTree : MonoBehaviour
{
    
    [SerializeField] private Magotte.TooltipUI.SkillButton[] talents;
    [SerializeField] private Magotte.TooltipUI.SkillButton[] unlockedByDefault;
    
    void Start()
    {
        
        ResetTalents();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void ResetTalents()
    {
        foreach (Magotte.TooltipUI.SkillButton talent in talents)
        {
            talent.Lock();
        }

        foreach (Magotte.TooltipUI.SkillButton talent in unlockedByDefault)
        {
            talent.Unlock();
        }
    }

}
