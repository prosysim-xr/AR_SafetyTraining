using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneARController : MonoBehaviour
{
	// References
	[SerializeField] private Camera arCamera;
	[SerializeField]ARRayCaster arRayCaster;
	[SerializeField] Step[] steps;

	bool isTaggerLostSignalSent = true;//may be enum to manage it, condition such as dont care if Tagger lost or not
	

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

		
		if (arRayCaster.currentTag == null)
		{ return; }
		if (arRayCaster.currentTag.aRBtnTag == Tagger.ARBtnTag.step0)
		{
			if (Input.GetMouseButtonDown(0))
			{
				//ResetTaggerLostSignal(); //This is to manage  is Tagger Lost Signal Sent Bool

				Debug.Log("Mouse Clicked");
				
				Step currentStep = arRayCaster.currentTag.transform.parent.parent.parent.GetComponent<Step>();
				currentStep.OnNextBtnClick?.Invoke();
				foreach (var step in steps)
				{
					if (step.GetComponent<Tagger>().aRBtnTag == Tagger.ARBtnTag.step1)
					{
						step.OnNextStep?.Invoke();//TODO: can use a break here
					}
				}
			}
		}
		else if (arRayCaster.currentTag.aRBtnTag == Tagger.ARBtnTag.step1)
		{
			if (Input.GetMouseButtonDown(0))
			{
				//ResetTaggerLostSignal(); //This is to manage  is Tagger Lost Signal Sent Bool

				Debug.Log("Mouse Clicked");

				Step currentStep = arRayCaster.currentTag.transform.parent.parent.parent.GetComponent<Step>();
				currentStep.OnNextBtnClick?.Invoke();
				foreach (var step in steps)
				{
					if (step.GetComponent<Tagger>().aRBtnTag == Tagger.ARBtnTag.step2)
					{
						step.OnNextStep?.Invoke();//TODO: can use a break here
					}
				}
			}
		}
		else if (arRayCaster.currentTag.aRBtnTag == Tagger.ARBtnTag.step2)
		{
			if (Input.GetMouseButtonDown(0))
			{
				//ResetTaggerLostSignal(); //This is to manage  is Tagger Lost Signal Sent Bool

				Debug.Log("Mouse Clicked");

				Step currentStep = arRayCaster.currentTag.transform.parent.parent.parent.GetComponent<Step>();
				currentStep.OnNextBtnClick?.Invoke();
				foreach (var step in steps)
				{
					if (step.GetComponent<Tagger>().aRBtnTag == Tagger.ARBtnTag.step3)
					{
						step.OnNextStep?.Invoke();//TODO: can use a break here
					}
				}
			}
		}
		else if (arRayCaster.currentTag.aRBtnTag == Tagger.ARBtnTag.step3)
		{
			if (Input.GetMouseButtonDown(0))
			{
				//ResetTaggerLostSignal(); //This is to manage  is Tagger Lost Signal Sent Bool

				Debug.Log("Mouse Clicked");

				Step currentStep = arRayCaster.currentTag.transform.parent.parent.parent.GetComponent<Step>();
				currentStep.OnNextBtnClick?.Invoke();
				foreach (var step in steps)
				{
					if (step.GetComponent<Tagger>().aRBtnTag == Tagger.ARBtnTag.step4)
					{
						step.OnNextStep?.Invoke();//TODO: can use a break here
					}
				}
			}
		}
		/*if (arRayCaster.currentTag.aRBtnTag == Tagger.ARBtnTag.step4)
		{
			if (Input.GetMouseButtonDown(0))
			{
				//ResetTaggerLostSignal(); //This is to manage  is Tagger Lost Signal Sent Bool

				Debug.Log("Mouse Clicked");

				Step currentStep = arRayCaster.currentTag.transform.parent.parent.parent.GetComponent<Step>();
				currentStep.OnNextBtnClick?.Invoke();
				foreach (var step in steps)
				{
					if (step.GetComponent<Tagger>().aRBtnTag == Tagger.ARBtnTag.step5)
					{
						step.OnNextStep?.Invoke();//TODO: can use a break here
					}
				}
			}
		}*/
		else
		{
			//SendTaggerLostSignal();
		}
	}

	void SendTaggerLostSignal()
	{
		if (!isTaggerLostSignalSent)
		{
			ARRayCaster.OnTaggerLost?.Invoke();
		}
		isTaggerLostSignalSent = true;
	}
	void ResetTaggerLostSignal()
	{
		isTaggerLostSignalSent = false;
	}
}
