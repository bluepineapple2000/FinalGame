using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{

    public int Health = 100;
    // I planned to make a healthsystem here, but I didn't get to work on multiplayer

   // public Slider Healthslider;
    // Start is called before the first frame update
    void Start()
    {
       // Healthslider.value = Health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Ghost")
        {
            Health = Health - 50;
         //   Healthslider.value = Health;
        }
    }
}
