using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateSunSkyBox : MonoBehaviour
{
    Light directionalLight;
    public Gradient timeOfDayColor;
    public AnimationCurve intensityGraph;
    public void RotateSun(Slider passedSlider)
    {
        Quaternion newRot = Quaternion.Euler(
            passedSlider.value, 
            transform.rotation.y, 
            transform.rotation.z);
        transform.rotation = newRot;

        float betweenZeroAndOne = (passedSlider.value - passedSlider.minValue)
            / (passedSlider.maxValue - passedSlider.minValue);
        directionalLight.color = timeOfDayColor.Evaluate(betweenZeroAndOne);
        directionalLight.intensity = intensityGraph.Evaluate(betweenZeroAndOne);
    }
    // Start is called before the first frame update
    void Start()
    {
        directionalLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
