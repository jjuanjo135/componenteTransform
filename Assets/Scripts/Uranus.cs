using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uranus : MonoBehaviour
{
    //public atributes
    public Transform SunTransform;
    public Transform UranusTransform;
    private float speedAngularUranus = 6.43f;
    private float speedRotationUranus = 6.43f;
    public float uranusOrbitalRadius;

    public void orbitUranus()
    {
        UranusTransform.RotateAround(
            SunTransform.position,
            Vector3.up,
            speedAngularUranus * Time.deltaTime * speedRotationUranus
        );
        Vector3 direction = (UranusTransform.position - SunTransform.position).normalized;
        UranusTransform.position = SunTransform.position + direction * uranusOrbitalRadius;
    }

    public void AlignUranusHeightWithSun()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.y = SunTransform.position.y;
        transform.position = currentPosition;
    }

    private void Start()
    {
        uranusOrbitalRadius = Vector3.Distance(UranusTransform.position, SunTransform.position);
    }

    private void Update()
    {
        orbitUranus();
        AlignUranusHeightWithSun();
    }
}
