using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //public atributes
    public Mercury Mercury;
    public Venus Venus;
    public Earth Earth;
    public Mars Mars;
    public Jupiter Jupiter;
    public Saturn Saturn;
    public Uranus Uranus;
    public Neptune Neptune;

    public void Update()
    {
        //Mercury
        Mercury.orbitMercury();
        Mercury.AlignMercuryHeightWithSun();
        //Venus
        Venus.orbitVenus();
        Venus.AlignVenusHeightWithSun();
        //Earth
        Earth.orbitEarth();
        Earth.AlignEarthHeightWithSun();
        //Mars
        Mars.orbitMars();
        Mars.AlignMarsHeightWithSun();
        //Jupiter
        Jupiter.orbitJupiter();
        Jupiter.AlignJupiterHeightWithSun();
        //Saturn
        Saturn.orbitSaturn();
        Saturn.AlignSaturnHeightWithSun();
        //Uranus
        Uranus.orbitUranus();
        Uranus.AlignUranusHeightWithSun();
        //Neptune
        Neptune.orbitNeptune();
        Neptune.AlignNeptuneHeightWithSun();
        //Uranus
        Uranus.orbitUranus();
        Uranus.AlignUranusHeightWithSun();
        //Neptune
        Neptune.orbitNeptune();
        Neptune.AlignNeptuneHeightWithSun();
    }
}
