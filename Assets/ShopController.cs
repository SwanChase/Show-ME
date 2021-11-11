using UnityEngine;
using DG.Tweening;

public class ShopController : MonoBehaviour
{
    private void OnEnable()
    {
        this.transform.DOScale(new Vector3(1, 1, 1), 1.5f);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            this.transform.DOScale(new Vector3(0, 0, 0), .5f).OnComplete(() =>
            {
                this.gameObject.SetActive(false);
              
            });

        }
    }
}
