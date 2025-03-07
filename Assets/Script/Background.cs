using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private MeshRenderer mesh;
    public float animationSpeed = 0.15f;
    void Awake()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        mesh.material.mainTextureOffset += new Vector2(animationSpeed* Time.deltaTime, 0);
    }
}
