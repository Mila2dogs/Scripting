using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health = 5;
    public int level = 1;
    public float speed = 1.2f;

    void Start()
    {
        health += level;
        print(" Жизней: " + health);
    }

    void Update()
    {
        Vector3 newPosition= transform.position;
        newPosition.x -= speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
