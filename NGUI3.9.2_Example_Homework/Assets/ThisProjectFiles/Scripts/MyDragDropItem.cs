using UnityEngine;
using System.Collections;

public class MyDragDropItem : UIDragDropItem {

    public UISprite sprite;
    public UILabel label;
    public int count = 1;

    //这么写就是当参数没有的时候默认传的是1
    public void AddCount(int number = 1)
    {
        count += number;
        label.text = count.ToString();
    }


    protected override void OnDragDropRelease(GameObject surface)
    {
        base.OnDragDropRelease(surface);

        Debug.Log(surface);

        if (surface.tag == "Cell")
        {
            //居中显示
            this.transform.parent = surface.transform;
            this.transform.localPosition = Vector3.zero;
        }
        else if (surface.tag == "MyDragDropItem")
        {
            Transform parent = surface.transform.parent;
            surface.transform.parent = this.transform.parent;
            surface.transform.localPosition = Vector3.zero;

            this.transform.parent = parent;
            this.transform.localPosition = Vector3.zero;
        }
        


        
        
    }

}
