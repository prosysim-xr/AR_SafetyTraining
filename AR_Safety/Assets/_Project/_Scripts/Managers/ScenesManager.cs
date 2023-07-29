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
		SceneManager.LoadScene(nameof(ARScenes.enterAR));
	}
	public void LoadMarkerAR()
	{
		SceneManager.LoadScene(nameof(ARScenes.markerAR));
	}
	public void LoadPlaneAR()
	{
		SceneManager.LoadScene(nameof(ARScenes.planeAR));

	}

}

public enum ARScenes
{
	enterAR = 0,
	planeAR = 1,
	markerAR =2
}
