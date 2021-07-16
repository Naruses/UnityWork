using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public static Image Healthbar;
    float value;

    private void Start()
    {
        Healthbar = GetComponent<Image>();
    }
    public static void SetHealthBarValue(float value)
    {
        Healthbar.fillAmount = value;
    }
    public static float GetHealthBarValue()
    {
        return Healthbar.fillAmount;
    }
    public void Health()
    {
        SetHealthBarValue(GetHealthBarValue() - 0.1f);
    }
}
