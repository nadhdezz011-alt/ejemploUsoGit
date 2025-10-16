using System;
using UnityEngine;

public class MovimientoArray : MonoBehaviour
{
    [SerializeField]
    GameObject cube;
    [SerializeField]
    float timeAnimation = 2f;
    [SerializeField]
    Transform[] transforms;
    
    int currentPosition = 0;
    void Start()
    {
        cube.transform.position = transforms[currentPosition].position;
        MoveCube();
    }

    void MoveCube()
    {
        currentPosition++;
        if (currentPosition >= transforms.Length)
        {
            currentPosition = 0;
            LeanTween.move(cube, transforms[currentPosition], timeAnimation);
        }
        else
        {
            LeanTween.move(cube, transforms[currentPosition], timeAnimation).setOnComplete(MoveCube);
        }
        
        

    }

}
