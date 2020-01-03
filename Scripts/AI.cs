using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{

    public GameObject pt;
    public GameObject BulletPrefab;
    public Transform Firepoint;

    // Update is called once per frame
    void Update()
    {
        Vector3 FinishPosition = transform.TransformDirection(Vector3.forward);
        Debug.DrawRay(transform.position, FinishPosition * 15, Color.red);

            RaycastHit hit;
        Ray ray = new Ray(transform.position, FinishPosition);

        int layer_mask = LayerMask.GetMask("Default");
        int layer_mask2 = LayerMask.GetMask("Player");
        
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, layer_mask, QueryTriggerInteraction.UseGlobal))
        {


        }
        else
        {
            if (Physics.Raycast(ray, out hit, 25f, layer_mask2, QueryTriggerInteraction.UseGlobal))
            {
                GameObject bulletGo = (GameObject)Instantiate(BulletPrefab, Firepoint.position, Firepoint.rotation);
                print("Ray hit by"+ hit.transform.name);
                pt.transform.position = hit.point;

            }
        }


    }
}
