using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField]
    GameObject particalSystem;

    [SerializeField]
    float movespeed = 4;
    float deathTimer = 5;

    [SerializeField]
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, deathTimer);
        transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * movespeed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.GetContact(0);
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                Debug.Log(collision.gameObject);
                Destroy(collision.gameObject);
            }
            //If the GameObject has the same tag as specified, output this message in the console
            if (particalSystem!)
            {
                Instantiate(particalSystem, contact.point, Quaternion.LookRotation(contact.normal));
                particalSystem.transform.parent = null;
                Disable();
            }
        }
    }
    private void Disable()
    {
        gameObject.SetActive(false);
    }
}
