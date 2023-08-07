using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClickMeCue : MonoBehaviour
{
	ARButton arBtn;
	bool scaleUp = true;
	TextMeshPro textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
		arBtn = this.transform.parent.GetComponent<ARButton>();
		textMeshPro = this.GetComponent<TextMeshPro>();	
        StartCoroutine(ScaleUpScaleDown());	
    }

    // Update is called once per frame
    void Update()
    {
		if (textMeshPro != null)
		{
			if (arBtn.IsUsed)
			{
				textMeshPro.enabled = true;
			}
			else
			{
				textMeshPro.enabled = false;
			}
		}
    }

	public IEnumerator ScaleUpScaleDown()
	{
		Vector3 originalScale = this.transform.localScale;
		while (true)
		{
				this.transform.localScale = Vector3.Lerp(this.transform.localScale, new Vector3(1.2f, 1.2f, 1.2f), 0.5f);
			yield return new WaitForSeconds(0.5f);
			
				this.transform.localScale = Vector3.Lerp(this.transform.localScale, originalScale, 0.5f);
			yield return new WaitForSeconds(0.5f);

		}
	}
}
