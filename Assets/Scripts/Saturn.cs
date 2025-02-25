using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saturn : MonoBehaviour
{
    //public atributes
    public Transform SunTransform;
    public Transform SaturnTransform;
    private float speedAngularSaturn = 9.69f;
    private float speedRotationSaturn = 9.69f;
    public float saturnOrbitalRadius;

    public void orbitSaturn()
    {
        SaturnTransform.RotateAround(
            SunTransform.position,
            Vector3.up,
            speedAngularSaturn * Time.deltaTime * speedRotationSaturn
        );
        Vector3 direction = (SaturnTransform.position - SunTransform.position).normalized;
        SaturnTransform.position = SunTransform.position + direction * saturnOrbitalRadius;
    }

    public void AlignSaturnHeightWithSun()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.y = SunTransform.position.y;
        transform.position = currentPosition;
    }

    private void Start()
    {
        saturnOrbitalRadius = Vector3.Distance(SaturnTransform.position, SunTransform.position);
    }

    private void Update()
    {
        orbitSaturn();
        AlignSaturnHeightWithSun();
    }
}
