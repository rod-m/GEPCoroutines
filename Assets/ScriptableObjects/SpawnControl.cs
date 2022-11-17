using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "SpawnData", menuName = "Spawn Control", order = 1)]

public class SpawnControl : ScriptableObject
{ 
    public float duration = 3f;
    public float distance = 3f;
    public int spray = 20;
    public float projectileLifeTime = 4f;
}
