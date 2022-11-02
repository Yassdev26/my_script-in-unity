using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hexone : MonoBehaviour
{
    public Material Materials;
    private MeshRenderer mesh;

    // Start is called before the first frame updatevoid Start()
    void update()
    {
        mesh = GetComponent<MeshRenderer>();
    }

// Update is called once per frame
void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            mesh.material = Materials;
        }
    }
}