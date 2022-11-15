using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    public Image Image;
    public void UpdateBar(float fillAmount)
    {
        Image.DOFillAmount(fillAmount, 0.5f);
        if (fillAmount > 0.6)
        {
            Image.DOColor(new Color32(41, 191, 18, 255), 0.5f);
        }
        else if (fillAmount > 0.3)
        {
            Image.DOColor(new Color32(255, 153, 20, 255), 0.5f);
        }
        else
        {
            Image.DOColor(new Color32(242, 27, 63, 255), 0.5f);
        }
    }
}
