using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneARController : MonoBehaviour
{
	// References
	[SerializeField] private Camera arCamera;
	[SerializeField]ARRayCaster arRayCaster;
	[SerializeField] Step[] steps;
	

	// Unity Callbacks
	private void Start()
	{
		ServiceLocator.Instance.userCameraTr = arCamera.transform;
		ServiceLocator.Instance.arRayCaster = arRayCaster;
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
			Debug.Log("Mouse Clicked");
			if(arRayCaster.currentTag == null){ return;}
			if (arRayCaster.currentTag.aRBtnTag == Tagger.ARBtnTag.step0)
			{
				Debug.Log("Mouse Clicked 2");
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
