using UnityEngine;
using System.Collections;

public class MyDragDropItem : UIDragDropItem {

    protected override void OnDragDropRelease(GameObject surface)
    {
        base.OnDragDropRelease(surface);

        Debug.Log(surface);

        //居中显示
        this.transform.parent = surface.transform;
        this.transform.localPosition = Vector3.zero;
    }

}
