using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    float movespeed = 4;
    float death = 5;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this, death);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * movespeed * Time.deltaTime;
    }
}
