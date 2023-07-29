using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : PersistentSingleton<ScenesManager>
{
	void Start()
	{
		LoadEnterAR();
	}
	public void LoadEnterAR()
	{
		SceneManager.LoadSceneAsync(nameof(ARScenes.EnterAR));
	}
	public void LoadMarkerAR()
	{
		SceneManager.LoadSceneAsync(nameof(ARScenes.MarkerAR));
	}
	public void LoadPlaneAR()
	{
		SceneManager.LoadSceneAsync(nameof(ARScenes.PlaneAR));

	}

}

public enum ARScenes
{
	EnterAR = 0,
	PlaneAR = 1,
	MarkerAR =2
}

