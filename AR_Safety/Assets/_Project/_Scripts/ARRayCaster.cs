
using UnityEngine;

public class ARRayCaster : MonoBehaviour
{
	// References
	[SerializeField] GameObject arRayCastOrigin;
	[SerializeField] float rayCastHitDist = 20f;
	[SerializeField] LineRenderer lineRenderer;
	[SerializeField] RaycastHit hit;
	public Tagger currentTag;

	// Unity Callbacks
	private void Update()
	{
		// Ray cast from ar session origin
		Ray ray = new Ray(arRayCastOrigin.transform.position + new Vector3(0, -0.33f, 0), arRayCastOrigin.transform.forward + new Vector3(0, 0.33f, 0));
		if (Physics.Raycast(ray, out hit, rayCastHitDist))
		{
			currentTag = hit.transform.GetComponent<Tagger>();
		}
		else
		{
		}
		lineRenderer.SetPosition(0, ray.origin);
		lineRenderer.SetPosition(1, ray.GetPoint(rayCastHitDist));
		Debug.Log("ray cast dist " + rayCastHitDist);

	}
	private void OnDrawGizmos()
	{
		// Draw ray from ar session origin
		Gizmos.color = Color.red;
		Gizmos.DrawRay(arRayCastOrigin.transform.position, arRayCastOrigin.transform.forward * rayCastHitDist);
	}
}
