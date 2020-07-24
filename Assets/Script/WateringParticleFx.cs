using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WateringParticleFx : MonoBehaviour
{
    ParticleSystem water;
    public static bool[] trigger = new bool[] { false, false, false, false, false,
                                                false, false, false, false, false,
                                                false, false, false, false, false,
                                                false, false, false, false, false,
                                                false, false, false, false, false,
                                                false, false, false, false, false,
                                                false, false, false, false, false,
                                                false, false, false, false, false,
                                                false, false, false, false, false,
                                                false, false, false, false, false,};

    // Start is called before the first frame update
    void Start()
    {
        water = GetComponent<ParticleSystem>();
        water.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            if (water.isStopped)
            {
                water.Play();
            } 
        }
        else if (Input.GetKey(KeyCode.E))
        {
            if (water.isPlaying)
            {
                water.Stop();
            }
        }
    }

    private void OnParticleCollision(GameObject other)
    {

        for(int i=0; i<SpawnPlantTree.treeCounter; i++)
        {
            if (int.Parse(other.tag) == i)
            {
                trigger[i] = true;
            }
        }
        Debug.Log(other.tag);
    }
    
}
