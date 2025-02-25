using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neptune : MonoBehaviour
{
    //public atributes
    public Transform SunTransform;
    public Transform NeptuneTransform;
    private float speedAngularNeptune = 5.43f;
    private float speedRotationNeptune = 5.43f;
    public float NeptuneOrbitalRadius;

    public void orbitNeptune()
    {
        NeptuneTransform.RotateAround(
            SunTransform.position,
            Vector3.up,
            speedAngularNeptune * Time.deltaTime * speedRotationNeptune
        );
        Vector3 direction = (NeptuneTransform.position - SunTransform.position).normalized;
        NeptuneTransform.position = SunTransform.position + direction * NeptuneOrbitalRadius;
    }

    public void AlignNeptuneHeightWithSun()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.y = SunTransform.position.y;
        transform.position = currentPosition;
    }

    private void Start()
    {
        NeptuneOrbitalRadius = Vector3.Distance(NeptuneTransform.position, SunTransform.position);
    }

    private void Update()
    {
        orbitNeptune();
        AlignNeptuneHeightWithSun();
    }
}
