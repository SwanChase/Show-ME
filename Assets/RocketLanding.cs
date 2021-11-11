using UnityEngine;

public class RocketLanding : MonoBehaviour
{
    public GameObject shopUI;

    private void Update()
    {
        if(this.transform.position.y <= 3)
        {
            this.GetComponent<Rigidbody>().useGravity = false;
        }
    }

    private void showUI()
    {
        shopUI.SetActive(true);
    }

    //Trigers

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.CompareTag("Player"))
        {
            showUI();
        }
    }
}
