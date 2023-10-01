using ObjectPooling;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed = 5;
    private void Update()
    {
        transform.position += Vector3.forward * (Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            //gameObject.SetActive(false);
            //Destroy(gameObject);
            SecondObjectPooling.Instance.pool.Release(gameObject);
        }
    }
}
