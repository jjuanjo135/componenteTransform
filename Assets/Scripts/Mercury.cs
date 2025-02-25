using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercury : MonoBehaviour
{
    //public atributes
    public Transform SunTransform;
    public Transform MercuryTransform;
    private float speedAngularMercury = 2.33f;
    private float speedRotationMercury = 47.87f;
    public float mercuryOrbitalRadius;

    public void orbitMercury()
    {
        MercuryTransform.RotateAround(
            SunTransform.position,
            Vector3.up,
            speedAngularMercury * Time.deltaTime * speedRotationMercury
        );
        Vector3 direction = (MercuryTransform.position - SunTransform.position).normalized;
        MercuryTransform.position = SunTransform.position + direction * mercuryOrbitalRadius;
    }

    public void AlignMercuryHeightWithSun()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.y = SunTransform.position.y;
        transform.position = currentPosition;
    }

    private void Start()
    {
        mercuryOrbitalRadius = Vector3.Distance(MercuryTransform.position, SunTransform.position);
    }

    private void Update()
    {
        orbitMercury();
        AlignMercuryHeightWithSun();
    }
}
