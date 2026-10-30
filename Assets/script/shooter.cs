using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(
                bulletPrefab,
                firePoint.position,
                firePoint.rotation
            );
        }

    }

}
