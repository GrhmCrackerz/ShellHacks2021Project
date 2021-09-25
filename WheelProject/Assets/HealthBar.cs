﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private Transform bar;

    // Start is called before the first frame update
    private void Awake()
    {
        bar = transform.Find("Bar");
        //bar.localScale = new Vector3(.4f, 1f);
    }

    public void SetSize(float sizeNormalized){
        bar.localScale = new Vector3(sizeNormalized, 1f);
    }

    public void setColor(Color color) {
        bar.Find("BarSprite").GetComponent<SpriteRenderer>().color = color;
    }
    
}
