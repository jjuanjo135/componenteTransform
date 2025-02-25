using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Venus : MonoBehaviour
{
    //public atributes
    public Transform SunTransform;
    public Transform VenusTransform;
    private float speedAngularVenus = 3.22f;
    private float speedRotationVenus = 35.02f;
    public float venusOrbitalRadius;

    public void orbitVenus()
    {
        VenusTransform.RotateAround(
            SunTransform.position,
            Vector3.up,
            speedAngularVenus * Time.deltaTime * speedRotationVenus
        );
        Vector3 direction = (VenusTransform.position - SunTransform.position).normalized;
        VenusTransform.position = SunTransform.position + direction * venusOrbitalRadius;
    }

    public void AlignVenusHeightWithSun()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.y = SunTransform.position.y;
        transform.position = currentPosition;
    }

    private void Start()
    {
        venusOrbitalRadius = Vector3.Distance(VenusTransform.position, SunTransform.position);
    }

    private void Update()
    {
        orbitVenus();
        AlignVenusHeightWithSun();
    }
}
