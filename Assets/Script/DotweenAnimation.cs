using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DotweenAnimation : MonoBehaviour
{
    private Vector3 originalScale;
    private Vector3 scaleChange;



    // Start is called before the first frame update
    void Start()
    {
        originalScale = transform.localScale;
        scaleChange = originalScale * 1;
        OnScale();

    }

    private void OnScale()
    {
      transform.DOScale(scaleChange, 1f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }
   
}
