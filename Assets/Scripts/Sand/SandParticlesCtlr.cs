using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandParticlesCtlr : MonoBehaviour
{
    ParticleSystem sand;
    float simulationSpeedOriginal;
    void Start()
    {
        sand = GetComponent<ParticleSystem>();
        simulationSpeedOriginal = sand.main.simulationSpeed;
    }
    void Update()
    {
        var main = sand.main;
        main.simulationSpeed = simulationSpeedOriginal *TimeMng.Instance.timeScale;
    }
}
