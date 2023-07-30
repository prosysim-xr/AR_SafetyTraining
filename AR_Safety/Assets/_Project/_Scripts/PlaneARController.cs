using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneARController : MonoBehaviour
{
	// References
	[SerializeField] private Camera arCamera;
	ARRayCaster arRayCaster;
	[SerializeField] Step[] steps;
	

	// Unity Callbacks
	private void Start()
	{
		ServiceLocator.Instance.userCameraTr = arCamera.transform;
		arRayCaster = FindAnyObjectByType<ARRayCaster>();
	}
	private void Update()
	{/*
		var touch = Input.GetTouch(0);
		if(touch.phase == TouchPhase.Began)
		{
			if(arRayCaster.currentTag.aRBtnTag == Tagger.ARBtnTag.step0)
			{
				Step currentStep = arRayCaster.currentTag.transform.parent.parent.parent.GetComponent<Step>();
				currentStep.OnNextBtnClick?.Invoke();
				foreach(var step  in steps)
				{
					if(step.GetComponent<Tagger>().aRBtnTag == Tagger.ARBtnTag.step1)
					{
						step.OnNextStep?.Invoke();
					}
				}
			}
		}*/

		if (Input.GetMouseButtonDown(0))
		{
			if (arRayCaster.currentTag.aRBtnTag == Tagger.ARBtnTag.step0)
			{
				Step currentStep = arRayCaster.currentTag.transform.parent.parent.parent.GetComponent<Step>();
				currentStep.OnNextBtnClick?.Invoke();
				foreach (var step in steps)
				{
					if (step.GetComponent<Tagger>().aRBtnTag == Tagger.ARBtnTag.step1)
					{
						step.OnNextStep?.Invoke();
					}
				}
			}
		}
	}
}
