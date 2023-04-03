using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class BezieTest : MonoBehaviour
{
    public Transform P0;
    public Transform P1;
    public Transform P2;
    public Transform P3;

    
    [Range(0, 1)]
    public float t;
    
    void Update()
    {
        
        transform.position = Bezie.getPoint(P0.position, P1.position, P2.position, P3.position, t);
        transform.rotation = Quaternion.LookRotation(Bezie.GetFirstDerivative(P0.position, P1.position, P2.position, P3.position, t));
    }

    private void OnDrawGizmos()
    {
        int sigmentsNumer = 20;
        Vector3 preveousePoint = P0.position;

        for (int i = 0; i < sigmentsNumer + 1; i++)
        {
            float paremetr = (float)i / sigmentsNumer;
            Vector3 point = Bezie.getPoint(P0.position, P1.position, P2.position, P3.position, paremetr);
            Gizmos.DrawLine(preveousePoint, point);
            preveousePoint = point;
        }
    }
}

