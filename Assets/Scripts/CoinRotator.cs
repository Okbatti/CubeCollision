using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotator : MonoBehaviour
{
    public Transform coinTransform;

    void Update()
    {
        coinTransform.Rotate(0, -1, 0);
    }
}
