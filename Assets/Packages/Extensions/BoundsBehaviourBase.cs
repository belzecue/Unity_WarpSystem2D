using UnityEngine;

/// <summary>
/// Bounds を持った MonoBehaviour です。
/// </summary>
[ExecuteInEditMode]
public class BoundsBehaviourBase : CacheBehaviourTransform
{
    #region Field

    /// <summary>
    /// Bounds 。
    /// 参照時には Property の Bounds を利用することを推奨します。
    /// </summary>
    public Bounds bounds;

    /// <summary>
    /// Gizmo を描画するかどうか。
    /// </summary>
    public bool drawGizmo;

    /// <summary>
    /// Gizmo の色。
    /// </summary>
    public Color gizmoColor = Color.white;

    #endregion Field

    #region Property

    /// <summary>
    /// Transform.position を基準とする Bounds を取得します。
    /// </summary>
    public Bounds Bounds
    {
        get
        {
            UpdateBounds();
            return this.bounds;
        }
    }

    #endregion Property

    #region Method

    /// <summary>
    /// 初期化時に呼び出されます。
    /// </summary>
    protected override void Awake()
    {
        base.Awake();
        UpdateBounds();
    }

    /// <summary>
    /// 更新時に呼び出されます。
    /// </summary>
    //protected virtual void Update()
    //{
    //    UpdateBounds();
    //}

    /// <summary>
    /// Gizmo の秒化時に呼び出されます。
    /// </summary>
    protected virtual void OnDrawGizmos()
    {
        if (this.drawGizmo)
        {
            Bounds bounds = Bounds;
            Color previousColor = Gizmos.color;
            Gizmos.color = this.gizmoColor;
            Gizmos.DrawWireCube(bounds.center, bounds.size);
            Gizmos.color = previousColor;
        }
    }

    /// <summary>
    /// Bounds を更新します。Transform が更新されるときなどに任意に呼び出します。
    /// </summary>
    public virtual void UpdateBounds()
    {
        this.bounds.center = base.transform.position;
    }

    #endregion Method
}