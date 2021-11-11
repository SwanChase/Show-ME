using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{

    float throwForce = 900;
    Vector3 objectPos;
    float distance;

    [SerializeField]
    bool canHold = true;
    [SerializeField]
    GameObject item;
    [SerializeField]
    GameObject tempPos;
    [SerializeField]
    bool isHolding = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isHolding)
        {
            item.GetComponent<Rigidbody>().velocity = Vector3.zero;
            item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            item.transform.SetParent(tempPos.transform);

            if (Input.GetKeyDown(KeyCode.E))
            {
                //yeet
            }
        }
        else
        {
            objectPos = item.transform.position;
            item.transform.SetParent(null);
            item.GetComponent<Rigidbody>().useGravity = true;
            item.transform.position = objectPos;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                isHolding = true;
                item.GetComponent<Rigidbody>().useGravity = false;
                item.GetComponent<Rigidbody>().detectCollisions = true;
            }
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            isHolding = false;
        }
    }
}
