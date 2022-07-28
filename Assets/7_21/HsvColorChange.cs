using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HsvColorChange : MonoBehaviour
{
    private Renderer changeMaterial;
    private float hue = 1f; 
    void Start()
    {
        changeMaterial = GetComponent<Renderer>();
        changeMaterial.material.SetColor("_EmissionColor", Color.HSVToRGB(1/360f, 1, 1));
    }

    void Update()
    {
        hue = (0.5f * Mathf.Sin(Time.time) + 0.5f);
        Debug.Log(hue);
        changeMaterial.material.SetColor("_EmissionColor", Color.HSVToRGB(hue, 1, 1));
        //changeMaterial.material.color = Color.HSVToRGB(hue, 1, 1);
    }
}
