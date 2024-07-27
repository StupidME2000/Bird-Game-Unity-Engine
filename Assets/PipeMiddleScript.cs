using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        if (logic == null)
        {
            Debug.LogError("LogicScript not found on GameObject with tag 'Logic'.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Intentionally left empty
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (logic == null)
        {
            Debug.LogError("LogicScript reference is null.");
            return;
        }


        if (collision.gameObject.layer == 3)
        {
            Debug.Log("Collision with layer 3 object: " + collision.gameObject.name);
            logic.AddScore(1);
        }
    }
}
