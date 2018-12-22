using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surukle : MonoBehaviour {
    Vector3 objectPos;
    void OnMouseDown()
    {
        objectPos = Camera.main.WorldToScreenPoint(transform.position);
    }

    void OnMouseDrag()
    {
        Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, objectPos.z);
        transform.position = Camera.main.ScreenToWorldPoint(pos);
    }
}
