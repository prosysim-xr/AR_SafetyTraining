using System;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class Step : MonoBehaviour
{
	[SerializeField] Transform infoPageTr;
	Transform userCameraTr;
	[SerializeField] bool toLookat = true;
	//Event
	public Action OnNextBtnClick;
	public Action OnNextStep;

	//Unity Callbacks
	private void OnEnable()
	{
		OnNextBtnClick += NextCalled;
		OnNextStep += NextStep;
	}
	void Start()
    {
		userCameraTr = ServiceLocator.Instance.userCameraTr;
    }

    // Update is called once per frame
    void Update()
    {

		if (toLookat){ infoPageTr.LookAt(userCameraTr); }
	}
	private void OnDisable()
	{
		OnNextBtnClick -= NextCalled;
		OnNextStep -= NextStep;
	}

	private void NextStep()
	{
		transform.GetChild(0).gameObject.SetActive(true);
	}

	private void NextCalled()
	{
		transform.GetChild(0).gameObject.SetActive(false);
	}
}
