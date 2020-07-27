using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watering : MonoBehaviour
{
    Obi.ObiEmitter emitter;
    public float emissionSpeed = 5;
    public float moveSpeed = 2;

    // Start is called before the first frame update
    void Start()
    {
        emitter = GetComponentInChildren<Obi.ObiEmitter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            emitter.speed = emissionSpeed;
        }

        else
        {
            emitter.speed = 0;
        }
    }
}
