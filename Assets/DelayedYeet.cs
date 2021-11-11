using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedYeet : MonoBehaviour
{
    [SerializeField]
    int TimeToYeet = 3;
    [SerializeField]
    float YeetForce = 900;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Yeeting());
        //InvokeRepeating("DelayedYeet", 3f);
    }

    IEnumerator Yeeting()
    {
        yield return new WaitForSeconds(TimeToYeet);
        GetComponent<Rigidbody>().AddForce(transform.forward * YeetForce);
        transform.parent = null;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
