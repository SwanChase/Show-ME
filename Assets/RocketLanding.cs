using UnityEngine;

public class RocketLanding : MonoBehaviour
{
    public GameObject shopUI;

    private void Start()
    {
        
    }

    private void Update()
    {
        
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
