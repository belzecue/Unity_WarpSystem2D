using UnityEngine;

public class WarpObjectController : CacheMonoBehaviourTransform
{
    #region Field

    public float speed = 0.1f;

    #endregion Field

    void Update()
    {
        Vector3 move = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            move = base.transform.up * speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            move = base.transform.right * -speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            move = base.transform.right * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            move = base.transform.up * -speed;
        }

        Vector3 goal = base.transform.position + move;

        base.transform.position = goal;
    }
}