using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]

public class ShaderPosition : MonoBehaviour
{
    public float radius = 25f;
    public float radiusMaxValue = 25f;
    public float speed = 15f;

    private float targetValue = 25f;

    // Update is called once per frame
    void Update()
    {
        Shader.SetGlobalVector("_Position", transform.position);
        Shader.SetGlobalFloat("_Radius", radius);

        if (Input.GetKeyDown(KeyCode.E))
        {
            Increase();
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            Decrease();
        }

        radius = Mathf.MoveTowards(radius, targetValue, speed * Time.deltaTime);
    }

    public void Increase()
    {
        targetValue = radiusMaxValue;
    }

    public void Decrease()
    {
        targetValue = 0f;
    }
}
