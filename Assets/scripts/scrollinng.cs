using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrollinng : MonoBehaviour
{
    [SerializeField] private RawImage _img;
    [SerializeField] private float x, y;

    void Update()
    {
        //rect=konum,yükseklik, genişlik için kullanılır
        _img.uvRect = new Rect(_img.uvRect.position + new Vector2(x, y) * Time.deltaTime, _img.uvRect.size);
    }
}
