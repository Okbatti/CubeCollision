using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    public RectTransform cubeTransform;

    void Update()
    {
        cubeTransform.Rotate(0.2f, 0.2f, 0.5f);
    }
}
