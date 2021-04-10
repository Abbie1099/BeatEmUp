using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackUniversal : MonoBehaviour
{
    public LayerMask collisonLayer;
    public float radius = 1.0f;
    public float damage = 1.0f;
    // Start is called before the first frame update
    public bool is_Pl, is_en;
    public GameObject hit_FX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DetectCollision();
    }
    void DetectCollision()
    {
        Collider[] hit = Physics.OverlapSphere(transform.position, radius, collisonLayer);
        if(hit.Length>0)
        {
            print(hit[0].gameObject.name);
        }
    }
}
