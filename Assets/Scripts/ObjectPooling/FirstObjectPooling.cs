using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

namespace ObjectPooling
{
    public class FirstObjectPooling : MonoBehaviour
    {
        #region Singleton

        public static FirstObjectPooling Instance;

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

        private List<GameObject> pool = new();
        private int poolSize = 10;

        [SerializeField] private GameObject bullet;

        [SerializeField] private Transform bulletParent;

        private void Start()
        {
            for (int i = 0; i < poolSize; i++)
            {
                GameObject bulletObject = Instantiate(bullet, bulletParent);
                bulletObject.SetActive(false);
                pool.Add(bulletObject);
            }
        }

        public GameObject GetPooledObject()
        {
            for (int i = 0; i < pool.Count; i++)
            {
                if (!pool[i].activeInHierarchy)
                    return pool[i];
            }

            ExpandPool(poolSize);

            return pool[^1];
        }

        private void ExpandPool(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                GameObject obj = Instantiate(bullet, bulletParent);
                obj.SetActive(false);
                pool.Add(obj);
            }
        }
    }
}
