using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
	// references
	[SerializeField] Image blackScreen;
	[SerializeField] Image FirstPanel;
	[SerializeField] Image TopPanel;
	[SerializeField] Image ARPanel;
	[Space]
	[SerializeField] Button btn_quit;
	[SerializeField] Button btn_back;
	[SerializeField] Button btn_enterAR;
	[SerializeField] Button btn_planeAR;
	[SerializeField] Button btn_markerAR;

	// events
	[SerializeField] Action OnUIStateUpdate;
	[SerializeField] UnityAction UIStateUpdate;

	UIStates_app ui_state;

	// Unity Callbacks
	void OnEnable()
	{
		OnUIStateUpdate += UIFlowUpdate;
		//UIStateUpdate += UIFlowUpdate;
		btn_enterAR.onClick.AddListener(HandleEnterARClick);
		btn_markerAR.onClick.AddListener(HandleMarkerARClick);
		btn_planeAR.onClick.AddListener(HandlePlaneARClick);
		btn_back.onClick.AddListener(Back);
		btn_quit.onClick.AddListener(Quit);
	}
	void OnDisable()
	{
		OnUIStateUpdate -= UIFlowUpdate;
		//UIStateUpdate -= UIFlowUpdate;
		btn_enterAR.onClick.RemoveListener(HandleEnterARClick);
		btn_markerAR.onClick.RemoveListener(HandleMarkerARClick);
		btn_planeAR.onClick.RemoveListener(HandlePlaneARClick);
		btn_back.onClick.RemoveListener(Back);
		btn_quit.onClick.RemoveListener(Quit);
	}

	// Methods
	public void UIFlowUpdate()
	{
		switch (ui_state)
		{
			case UIStates_app.mainMenu:
				blackScreen.transform.SetSiblingIndex(0);
				TopPanel.gameObject.SetActive(false);
				ARPanel.gameObject.SetActive(false);
				break;
			case UIStates_app.subMenu:
				FirstPanel.transform.SetSiblingIndex(0);
				blackScreen.transform.SetSiblingIndex(1);
				ARPanel.gameObject.SetActive(true);
				ARPanel.transform.SetSiblingIndex(2);
				TopPanel.gameObject.SetActive(true);
				TopPanel.transform.SetSiblingIndex(3);
				break;

		}
	}

	public void HandleEnterARClick()
	{
		ui_state = UIStates_app.subMenu;
		OnUIStateUpdate?.Invoke();
	}
	public void HandlePlaneARClick()
	{
		/*ui_state = UIStates_app.subMenu;
		OnUIStateUpdate?.Invoke();*/
		Debug.Log("plane AR ");
		ScenesManager.Instance.LoadPlaneAR();
	}
	public void HandleMarkerARClick()
	{
		/*ui_state = UIStates_app.subMenu;
		OnUIStateUpdate?.Invoke();*/
		Debug.Log("marker AR ");
		ScenesManager.Instance.LoadMarkerAR();
	}

	public void Quit()
	{
		Debug.Log("quit");
		Application.Quit();
	}
	public void Back()
	{
		ui_state = UIStates_app.mainMenu;
		OnUIStateUpdate?.Invoke();
	}

}

public enum UIStates_app
{
	mainMenu = 0,
	subMenu = 1
}
