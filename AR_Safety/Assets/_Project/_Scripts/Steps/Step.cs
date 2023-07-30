using System;
using UnityEngine;

public class Step : MonoBehaviour
{
	public Transform infoPageTr;
	Transform userCameraTr;

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
		infoPageTr.LookAt(userCameraTr);
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
