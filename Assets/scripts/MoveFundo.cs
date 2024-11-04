using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveFundo : MonoBehaviour
{
    public MeshRenderer mr;
    public float Speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mr.material.mainTextureOffset += new Vector2(Speed*Time.deltaTime,0);
    }
}
