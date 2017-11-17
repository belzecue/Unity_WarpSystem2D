using UnityEngine;

/// <summary>
/// Transform に連動する Bounds を持った MonoBehaviour です。
/// </summary>
[ExecuteInEditMode]
public class BoundsBehaviourBase : CacheMonoBehaviourTransform
{
    #region Field

    /// <summary>
    /// Bounds 。
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
    protected virtual void Update()
    {
        UpdateBounds();
    }

    /// <summary>
    /// Gizmo の秒化時に呼び出されます。
    /// </summary>
    protected virtual void OnDrawGizmos()
    {
        if (this.drawGizmo)
        {
            Color previousColor = Gizmos.color;
            Gizmos.color = this.gizmoColor;
            Gizmos.DrawWireCube(this.bounds.center, this.bounds.size);
            Gizmos.color = previousColor;
        }
    }

    /// <summary>
    /// Bounds を更新します。
    /// Transform を更新するときに任意に呼び出します。
    /// </summary>
    public virtual void UpdateBounds()
    {
        this.bounds.center = base.transform.position;
    }

    #endregion Method
}