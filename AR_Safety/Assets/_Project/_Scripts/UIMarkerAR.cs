using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIMarkerAR : MonoBehaviour
{
	[SerializeField] Button btn_back;

	// events
	[SerializeField] Action OnUIStateUpdate;

	// Unity Callbacks
	void OnEnable()
	{
		btn_back.onClick.AddListener(Back);
	}

	void OnDisable()
	{
		btn_back.onClick.RemoveListener(Back);
	}


	public void Back()
	{
		ScenesManager.Instance.LoadEnterAR();
	}
}
public enum UIStates_MarkerAR
{
	mainMenu = 0,
	subMenu = 1
}
