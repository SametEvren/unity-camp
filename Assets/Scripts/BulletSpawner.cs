using System.Collections;
using ObjectPooling;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform handTransform;
    [SerializeField] private Transform bulletParent;
    private void Start()
    {
        StartCoroutine(CreateBullet());
    }

    private IEnumerator CreateBullet()
    {
        yield return new WaitForSeconds(0.5f);
        //Instantiate(bulletPrefab, handTransform.position, Quaternion.identity, bulletParent);

        var bullet = SecondObjectPooling.Instance.pool.Get();
        
        // var bullet = FirstObjectPooling.Instance.GetPooledObject();
        // if (bullet != null)
        // {
        //     bullet.transform.position = handTransform.position;
        //     bullet.SetActive(true);
        // }
        StartCoroutine(CreateBullet());
    }
}