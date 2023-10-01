using System;
using UnityEngine;
using UnityEngine.Pool;

namespace ObjectPooling
{
    public class SecondObjectPooling : MonoBehaviour
    {
        #region Singleton

        public static SecondObjectPooling Instance;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
        }

        #endregion

        public ObjectPool<GameObject> pool;
        public GameObject bulletPrefab;
        public Transform bulletParent;
        public int poolAmount;
        public int maxCapacity;
        public Transform handTransform;

        private void Start()
        {
            pool = new ObjectPool<GameObject>(() => 
                { return Instantiate(bulletPrefab, bulletParent); }
                , bullet =>
                {
                    bullet.SetActive(true);
                    bullet.transform.position = handTransform.position;
                }, bullet => { bullet.SetActive(false); }
                , bullet => { Destroy(bullet.gameObject); }
                , false, poolAmount,maxCapacity);
        }
    }
}
