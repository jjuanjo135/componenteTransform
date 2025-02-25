using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mars : MonoBehaviour
{
    //public atributes
    public Transform SunTransform;
    public Transform MarsTransform;
    private float speedAngularMars = 4.4f;
    private float speedRotationMars = 24.07f;
    public float marsOrbitalRadius;

    public void orbitMars()
    {
        MarsTransform.RotateAround(
            SunTransform.position,
            Vector3.up,
            speedAngularMars * Time.deltaTime * speedRotationMars
        );
        Vector3 direction = (MarsTransform.position - SunTransform.position).normalized;
        MarsTransform.position = SunTransform.position + direction * marsOrbitalRadius;
    }

    public void AlignMarsHeightWithSun()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.y = SunTransform.position.y;
        transform.position = currentPosition;
    }

    private void Start()
    {
        marsOrbitalRadius = Vector3.Distance(MarsTransform.position, SunTransform.position);
    }

    private void Update()
    {
        orbitMars();
        AlignMarsHeightWithSun();
    }
}
