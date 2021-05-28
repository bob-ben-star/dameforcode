using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class Par : MonoBehaviour
{
    ParticleSystem par;
    // Start is called before the first frame update
    void Awake()
    {
        par = this.GetComponent<ParticleSystem>();

    }
    MainModule main;
    private void Start()
    {
        main = par.main;
        main.duration = 100;
        main.loop = true;
        main.prewarm = true;
        main.startSpeed = 100;
        main.simulationSpeed = 3;
        main.startColor = Color.green;


        var emission = par.emission;
        emission.rateOverTime = 100;
        emission.SetBursts(new Burst[] { new Burst() { time = 3, count = 1000, cycleCount = int.MaxValue } });

        par.Play();
        var shape = par.shape;

        // shape.angle = 1.3f;
        var trigger = par.trigger;


    }

    private static object lockObj = new object();
    private static Par instances;
    public static Par Instences
    {
        get
        {
            lock (lockObj)
            {

                return instances ?? (instances = FindObjectOfType<Par>());
            }
        }

    }
    private void OnParticleCollision(GameObject other)
    {
        print("pengz");
    }

    private void OnParticleTrigger()
    {
        print("Trigger");
    }
}
