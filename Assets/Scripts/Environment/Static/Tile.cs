using UnityEngine;
using System.Collections;

public abstract class Tile : MonoBehaviour
{
    [SerializeField] protected SpriteRenderer _renderer;

    private void Awake()
    {  
        Init();
    }

    protected virtual void Init()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }
}

