using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Optics.Utils;

public class CameraManager : MonoSingleton<CameraManager>
{
    private Transform _followPoint;

    public Transform followPoint
    {
        get => _followPoint;
        set => _followPoint = value;
    }

    private void Awake()
    {
       _followPoint = transform.Find("FollowPoint");
    }
}
