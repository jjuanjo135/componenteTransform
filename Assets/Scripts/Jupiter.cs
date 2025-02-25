using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jupiter : MonoBehaviour
{
    //public atributes
    public Transform SunTransform;
    public Transform JupiterTransform;
    private float speedAngularJupiter = 13.07f;
    private float speedRotationJupiter = 13.07f;
    public float jupiterOrbitalRadius;

    public void orbitJupiter()
    {
        JupiterTransform.RotateAround(
            SunTransform.position,
            Vector3.up,
            speedAngularJupiter * Time.deltaTime * speedRotationJupiter
        );
        Vector3 direction = (JupiterTransform.position - SunTransform.position).normalized;
        JupiterTransform.position = SunTransform.position + direction * jupiterOrbitalRadius;
    }

    public void AlignJupiterHeightWithSun()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.y = SunTransform.position.y;
        transform.position = currentPosition;
    }

    private void Start()
    {
        jupiterOrbitalRadius = Vector3.Distance(JupiterTransform.position, SunTransform.position);
    }

    private void Update()
    {
        orbitJupiter();
        AlignJupiterHeightWithSun();
    }
}
