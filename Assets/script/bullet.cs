using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bullet : MonoBehaviour
{
    [Header("子彈速度")]
    public float speed = 12f;

    [Header("子彈存活時間")]
    public float lifeTime = 3f;

    void Start()
    {

        Destroy(gameObject, lifeTime);
    }

    void Update()
    {

        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            Scoremanager scoreManager = FindObjectOfType<Scoremanager>();
            if (scoreManager != null)
            {
                scoreManager.AddScore(10);
            }

            Destroy(other.gameObject);
            Destroy(gameObject);
        }


        else if (other.CompareTag("wall"))
        {
            Destroy(gameObject);
        }

    }
}
