using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowPlayer : MonoBehaviour
{
    //use collider to detect player and turn player invisable and reposition thrown player at location of impact
    [SerializeField]
    int TimeToYeet = 2;
    [SerializeField]
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

        if (Input.GetKeyDown(KeyCode.E))
        {
            isHolding = true;
            Instantiate(item, tempPos.transform);
            item.GetComponent<Rigidbody>().useGravity = false;
            item.GetComponent<Rigidbody>().detectCollisions = true;
        }

        if (isHolding)
        {
            item.GetComponent<Rigidbody>().velocity = Vector3.zero;
            item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            
            StartCoroutine(Yeeting());

        }
        else
        {
            objectPos = item.transform.position;
            item.transform.SetParent(null);
            item.GetComponent<Rigidbody>().useGravity = true;
            item.transform.position = objectPos;
        }
    }

    IEnumerator Yeeting()
    {
        yield return new WaitForSeconds(TimeToYeet);
        isHolding = false;
    }
}
