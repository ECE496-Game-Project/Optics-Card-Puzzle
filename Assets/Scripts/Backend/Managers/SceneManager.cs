using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Optics.Utils;

public class SceneManager : MonoSingleton<SceneManager>
{
    private void Awake()
    {
        // Load all the levels one by one as a list
    }

    void Start()
    {
        GridManager.Instance.GenerateGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
