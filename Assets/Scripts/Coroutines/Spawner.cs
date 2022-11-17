using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public SpawnControl spawnControl;
    private Renderer _renderer;
    public Transform projectile;
    void Awake()
    {
        StartCoroutine("Spray");
    }
    
    IEnumerator Spray()
    {
        for (int i = 0; i < spawnControl.spray; i++)
        {
            Instantiate(projectile, Vector3.up, Quaternion.identity);
            yield return new WaitForSeconds(0.2f);
            
        }
        
    }

}
