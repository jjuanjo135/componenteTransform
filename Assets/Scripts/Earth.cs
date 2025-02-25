using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    //public atributes
    public Transform SunTransform; //sun
    public Transform EarthTransform; //Earth
    private float speedAngularEarth = 5.4f; // angular speed rotation
    private float speedRotationEarth = 29.78f; // how fast earth move around sun
    public float earthOrbitalRadius; //distance between sun and earth

    public void orbitEarth()
    {
        EarthTransform.RotateAround(
            SunTransform.position,
            Vector3.up,
            speedAngularEarth * Time.deltaTime * speedRotationEarth
        );
        Vector3 direction = (EarthTransform.position - SunTransform.position).normalized;
        EarthTransform.position = SunTransform.position + direction * earthOrbitalRadius;
    }

    public void AlignEarthHeightWithSun()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.y = SunTransform.position.y;
        transform.position = currentPosition;
    }

    private void Start()
    {
        //balance in x, y and z between sun and others planets
        earthOrbitalRadius = Vector3.Distance(EarthTransform.position, SunTransform.position);
    }

    private void Update()
    {
        orbitEarth(); //orbit earth around sun
        AlignEarthHeightWithSun(); //stand position y in case
    }
}
