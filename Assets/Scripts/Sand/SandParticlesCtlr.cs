using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandParticlesCtlr : MonoBehaviour
{
    ParticleSystem sand;
    float simulationSpeedOriginal;
    [SerializeField] Color colorOriginal;

    void Start()
    {
        sand = GetComponent<ParticleSystem>();
        simulationSpeedOriginal = sand.main.simulationSpeed;
    }
    void Update()
    {
        var main = sand.main;
        var overTimerColor = sand.colorOverLifetime;
        main.simulationSpeed = simulationSpeedOriginal *TimeMng.Instance.timeScale;
        overTimerColor.color = new Color(colorOriginal.r * (3-(TimeMng.Instance.timeScale*2)),colorOriginal.g *(3-(TimeMng.Instance.timeScale*2)),colorOriginal.b * (3-(TimeMng.Instance.timeScale*2)),colorOriginal.a);
    }
}
