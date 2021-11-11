using UnityEngine;

public class DerplShoot : MonoBehaviour
{
    [SerializeField]
    GameObject barrel;
    [SerializeField]
    GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            Fire();
        }
    }

    private void Fire()
    {
        Instantiate(bullet, barrel.transform);
    }
}
