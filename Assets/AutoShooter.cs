using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoShooter : MonoBehaviour
{
    [Header("子彈預製物")]
    public GameObject bulletPrefab;

    [Header("發射位置")]
    public Transform firePoint;

    [Header("發射間隔")]
    public float fireInterval = 0.5f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= fireInterval)
        {
            timer = 0f;

            Instantiate(
                bulletPrefab,
                firePoint.position,
                firePoint.rotation
            );
        }
    }
}