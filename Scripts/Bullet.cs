using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public Transform target; // update 2
    public GameObject impactEffect; // update 2
    public float speed = 70f;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        Vector3 dir = transform.TransformDirection(Vector3.forward);
        float distancethisframe = speed * Time.deltaTime;
        transform.Translate(dir.normalized * distancethisframe, Space.World);
    }

    void HitTarget() // update 2
    {

    }
}
