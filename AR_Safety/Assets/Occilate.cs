using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Occilate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.DOMoveY(0.1f, 1f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }
}
