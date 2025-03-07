using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float minHeight;
    public float maxHeight;
    public float spawnRate;
    public GameObject pipe;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject tmp = Instantiate(pipe, transform.position, Quaternion.identity);
        tmp.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
}
