using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Oxygen2 : MonoBehaviour
{
	[SerializeField] private Slider slider;
    [SerializeField] private Gradient gradient;
    [SerializeField] private Image fill;

	public void SetMaxOxygen(int oxygen)
	{
		slider.maxValue = oxygen;
		slider.value = oxygen;

		//fill.color = gradient.Evaluate(1f);
	}

	public void SetOxygen(int oxygen)
	{
		slider.value = oxygen;

		//fill.color = gradient.Evaluate(slider.normalizedValue);
	}
}
