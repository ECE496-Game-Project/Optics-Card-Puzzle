using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Drop on" + gameObject.name);
        DraggableObj draggedObject = eventData.pointerDrag.GetComponent<DraggableObj>();
        if (draggedObject == null) return;
        draggedObject.ParentToReturnTo = this.transform;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

