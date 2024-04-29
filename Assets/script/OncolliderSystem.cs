using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OncolliderSystem : MonoBehaviour
{
    [SerializeField] private SurfaceEffector2D RoadSHape;

    [SerializeField] private ParticleSystem skaterParticleSystem;
    [SerializeField] private ParticleSystem HeadParticleSystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "RoadShape")
        {
            skaterParticleSystem.Play();
            
        }
       
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "RoadShape")
        {
            skaterParticleSystem.Stop();
            
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "RoadShape")
        {
            HeadParticleSystem.Play();
            RoadSHape.speed = 0f;
            RoadSHape.speedVariation = 0f;
        }
    }

  
}
