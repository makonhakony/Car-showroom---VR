using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRotator : MonoBehaviour
{
    public void RotateCar(float sliderValue)
    {
        Vector3 newRotation = new Vector3(0, sliderValue, 0);
        transform.rotation = Quaternion.Euler(newRotation);
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
