using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    [SerializeField]
    private MeshRenderer meshrenderer;

    Vector2 vector = new Vector2(0, 1 * Time.deltaTime);
    // Start is called before the first frame update
    void Start()
    {
        // material = GetComponentInChildren<Material>();
    }

    // Update is called once per frame
    void Update()
    {
        meshrenderer.material.mainTextureOffset += vector;

    }
}
