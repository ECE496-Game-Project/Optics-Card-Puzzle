using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableTile : Tile
{
    [SerializeField] private GameObject _highlight;

    protected override void Init()
    {
        base.Init();
        _highlight = transform.Find("Highlight")?.gameObject;
    }

    protected virtual void OnMouseEnter()
    {
        _highlight?.SetActive(true);
    }

    protected virtual void OnMouseExit()
    {
        _highlight?.SetActive(false);
    }
}
