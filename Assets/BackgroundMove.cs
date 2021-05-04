using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    [SerializeField]
    private MeshRenderer[] meshrenderer;

    Vector2 vector;
    // Start is called before the first frame update
    void Start()
    {
        vector = new Vector2(0, 0.1f * Time.deltaTime);
        // material = GetComponentInChildren<Material>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach(var mr in meshrenderer)
        {
            mr.material.mainTextureOffset += vector;
        }
       
    }
}
