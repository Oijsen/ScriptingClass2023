using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMatchBehaviour : MatchBehavior
{
    public ColorIDDataList colorIDDataListObj;

    private void Awake()
    {
        //idObj = colorIDDataListObj.currentColor;
        colorIDDataListObj.SetCurrentColorRandomly();
    }

    public void ChangeColor(SpriteRenderer renderer)
    {
        var newColor = idObj as ColorID;
        renderer.color = newColor.value;
    }
}
