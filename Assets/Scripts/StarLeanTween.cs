using TMPro;
using UnityEngine;

public class StarLeanTween : MonoBehaviour
{
    [SerializeField]
    GameObject Objeto;
    [SerializeField]
    public float animationTime = 0.75f;
    [SerializeField]
    LeanTweenType curva;
    [SerializeField]
    public float animationScaleTime = 1f;
    [SerializeField]
    LeanTweenType curvaScale;
    void Start()
    {
        LeanTween.moveLocalY(Objeto, 0.0f, animationTime).setEase(curva);
        Objeto.transform.localScale = new Vector3(1.0f, 2.0f, 1.0f);
        LeanTween.scaleY(Objeto, 1f, animationScaleTime).setEase(curvaScale).setOnComplete(AnimacionLatido);
    }

    void AnimacionLatido()
    {
        LeanTween.scale(Objeto, Vector3.one * 1.5f, animationScaleTime).setEaseInBounce();
    }

}
