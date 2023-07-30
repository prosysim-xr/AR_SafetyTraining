using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tagger : MonoBehaviour
{
	public ARBtnTag aRBtnTag = ARBtnTag.None;
	public ARBtnSubTag aRBtnSubTag = ARBtnSubTag.None;
	public enum ARBtnTag
	{
		None = 0,
		step1 = 1,
		step2 = 2,
		step3 = 3,
		step4 = 4,
		step0 = 5

	}
	public enum ARBtnSubTag
	{
		None = 0,
		step1 = 1,
		step2 = 2,
		step3 = 3,
		step4 = 4,
		step0 = 5
	}
}


