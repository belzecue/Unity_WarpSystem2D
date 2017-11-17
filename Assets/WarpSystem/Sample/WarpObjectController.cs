using UnityEngine;

public class WarpObjectController : CacheMonoBehaviourTransform
{
    #region Field

    public float speed = 0.1f;

    #endregion Field

    void Update ()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            base.transform.position += base.transform.up * speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            base.transform.position += base.transform.right * -speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            base.transform.position += base.transform.right * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            base.transform.position += base.transform.up * -speed;
        }
    }
}