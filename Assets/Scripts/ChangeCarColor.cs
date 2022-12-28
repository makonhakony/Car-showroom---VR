using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCarColor : MonoBehaviour
{
    public MeshRenderer[] renderers;

    public void ChangeColorOnRenderers(ColorValueHolder colorValue)
    {
        foreach (MeshRenderer rend in renderers)
        {
            rend.material.color = colorValue.passedColor;
        }
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
