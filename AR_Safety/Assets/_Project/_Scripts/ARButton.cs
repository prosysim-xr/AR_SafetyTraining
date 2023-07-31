using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARButton : MonoBehaviour
{
	ARRayCaster arRayCaster;
	bool _isUsed;
	public bool IsUsed
	{
		get
		{
			return _isUsed;
		}
		set
		{
			/*if(value != _isUsed)
			{
				if (value == false)
				{
					GetComponent<MeshRenderer>().material.color = Color.white;
				}
				else
				{
					GetComponent<MeshRenderer>().material.color = Color.green;
				}
				_isUsed = value;
			}*/
			if (value == false)
			{
				GetComponent<MeshRenderer>().material.color = Color.white;
			}
			else
			{
				GetComponent<MeshRenderer>().material.color = Color.green;
			}
			_isUsed = value;
		}
	}

	private void Start()
	{
		arRayCaster = ServiceLocator.Instance.arRayCaster;
		ARRayCaster.OnTaggerLost += TaggerLost;
	}

	private void OnDestroy()
	{
		ARRayCaster.OnTaggerLost -= TaggerLost;

	}

	private void TaggerLost()
	{
		/*if(IsUsed)
		{
			GetComponent<MeshRenderer>().material.color = Color.white;
		}*/
		Debug.Log("// Tagger Lost Called 0");
		IsUsed = false;
	}
}
