using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBox : MonoBehaviour
{
    public SpawnControl spawnControl;

    void Awake()
    {
        Destroy(gameObject, spawnControl.projectileLifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * (spawnControl.distance * Time.deltaTime));
        
    }
}
