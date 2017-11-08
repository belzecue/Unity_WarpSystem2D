using UnityEngine;
using XJ.Unity3D.Extensions;

public class GizmosExSample : MonoBehaviour
{
    protected virtual void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        GizmosEx.DrawCross(base.transform.position, 1);
    }
}