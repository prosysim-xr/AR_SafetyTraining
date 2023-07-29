using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneARController : MonoBehaviour
{
	// References
	[SerializeField] GameObject arRayCastOrigin;
	[SerializeField] float rayCastHitDist = 20f;
	[SerializeField] LineRenderer lineRenderer;


	// Unity Callbacks
	private void Update()
	{
		// Ray cast from ar session origin
		RaycastHit hit;
		Ray ray = new Ray(arRayCastOrigin.transform.position, arRayCastOrigin.transform.forward);
		if(Physics.Raycast(ray, out hit, rayCastHitDist))
		{
			Debug.Log(".. "+hit.transform.name);
		}
		lineRenderer.SetPosition(0, ray.origin);
		lineRenderer.SetPosition(1, ray.GetPoint(rayCastHitDist));

	}
	private void OnDrawGizmos()
	{
 		// Draw ray from ar session origin
		Gizmos.color = Color.red;
		Gizmos.DrawRay(arRayCastOrigin.transform.position, arRayCastOrigin.transform.forward * rayCastHitDist);
	}
}
