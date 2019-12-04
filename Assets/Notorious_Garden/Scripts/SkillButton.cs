using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Magotte.TooltipUI
{
    public class SkillButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
    {
        [SerializeField] private Skill skill;
        [SerializeField] private TooltipPopup tooltipPopup;
        [SerializeField] private GameObject unlock;
        private GameObject btn;
        private Button Btn;
        private Button UnlBtn;
        private Image sprite;
        private Image nxtSprite;
        public int updateCost;
        public void OnPointerEnter(PointerEventData eventData)
        {
            tooltipPopup.DisplayInfo(skill);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            tooltipPopup.HideInfo();
        }
        
        private void Awake()
        {
            sprite = GetComponent<Image>();
            nxtSprite = unlock.GetComponent<Image>();
            btn = this.gameObject;
            Btn = btn.GetComponent<Button>();
            UnlBtn = unlock.GetComponent<Button>();
        }
        public void Lock()
        {
            sprite.color = Color.gray;
            Btn.interactable = false;
            
        }

        public void Unlock()
        {
            sprite.color = Color.white;
            Btn.interactable = true;
            
        }

        public void RemoveEctoplasm()
        {
            // TODO: Make White as long as the user can purchase
            
            if (Player.instance.score - skill.EctoDmg >= 0.000000001 && Btn.interactable != false)
            {
                Player.instance.score -= skill.EctoDmg;
                Lock();
                Btn.interactable = false;
                UnlBtn.interactable = true;
                nxtSprite.color = Color.white;
                

            }


        }

        public void OnPointerClick(PointerEventData eventData)
        {
            RemoveEctoplasm();

        }
    }

}

