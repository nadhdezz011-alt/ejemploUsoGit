using System;
using UnityEngine;

public class CuboLeenTween : MonoBehaviour
{
    [SerializeField]
    GameObject Cubo;
    [SerializeField]
    public float animationTime = 0.75f;
    [SerializeField]
    LeanTweenType curva;
    void Start()
    {  
        LeanTween.moveLocalZ(Cubo, -3.86f, animationTime).setEase(curva).setOnComplete(AnimacionX); 
    }
    void AnimacionX()
    {
        LeanTween.moveLocalX(Cubo, -3.69f, animationTime).setEase(curva).setOnComplete(AnimacionZ2);
    }
    void AnimacionZ2()
    {
        LeanTween.moveLocalZ(Cubo, 3.93f, animationTime).setEase(curva).setOnComplete(AnimacionX2);
    }
   void AnimacionX2()
    {
        LeanTween.moveLocalX(Cubo, 3.95f, animationTime).setEase(curva);
    }
}
