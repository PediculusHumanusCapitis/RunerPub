using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Bezie
{
    public static Vector3 getPoint(Vector3 p0,Vector3 p1,Vector3 p2,Vector3 p3,float t){
        t = Mathf.Clamp01(t);
        float oneMinust = 1f - t;
        return p0 * Mathf.Pow(oneMinust, 3) + p1 * 3f * t * Mathf.Pow(oneMinust, 2) + p2 * 3f * oneMinust * t * t + p3 * t * t * t;
    }

    public static Vector3 GetFirstDerivative(Vector3 p0,Vector3 p1,Vector3 p2,Vector3 p3,float t){
        t = Mathf.Clamp01(t);
        float oneMinust = 1f - t;
        return 3f * Mathf.Pow(oneMinust, 2) * (p1 - p0) + 6f * oneMinust * t * (p2 - p1) + 3f * t * t * (p3 - p2);
    }
}
