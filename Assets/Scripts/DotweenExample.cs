using System;
using DG.Tweening;
using UnityEngine;
using Random = UnityEngine.Random;

public class DotweenExample : MonoBehaviour
{
    public Transform cubeTransform, sphereTransform;
    public Material cubeMaterial, sphereMaterial;
    public float time;

    private void Start()
    {
        // cubeTransform.DOMove(new Vector3(0, 2.5f, 10), time).SetEase(Ease.Linear).SetLoops(-1,LoopType.Yoyo);
        // cubeTransform.DORotate(new Vector3(360, 0, 0), time, RotateMode.FastBeyond360).SetLoops(-1,LoopType.Yoyo);
        // sphereTransform.DOLocalMove(new Vector3(1, 0, 0), time).SetEase(Ease.Linear).SetLoops(-1,LoopType.Yoyo);

        // cubeTransform.DOMoveX(10, 1f).OnComplete(() =>
        // {
        //     cubeTransform.DOMoveZ(11f, 0.5f);
        // });

        var sequence = DOTween.Sequence();
        sequence.Append(cubeTransform.DOMove(new Vector3(0, 2.5f, 10), time).SetEase(Ease.Linear).SetLoops(-1,LoopType.Yoyo));
        sequence.Join(cubeTransform.DORotate(new Vector3(360, 0, 0), time, RotateMode.FastBeyond360).SetLoops(-1,LoopType.Yoyo));
        sequence.Join(sphereTransform.DOLocalMove(new Vector3(1, 0, 0), time).SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Yoyo));
        
        ChangeColor();
    }

    private void ChangeColor()
    {
        cubeMaterial.DOColor(Random.ColorHSV(), 0.3f).OnComplete(ChangeColor);
        sphereMaterial.DOColor(Random.ColorHSV(), 0.3f);
    }
}
