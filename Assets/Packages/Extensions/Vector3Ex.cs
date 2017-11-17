using UnityEngine;

/// <summary>
/// Vector3 に関する拡張機能を実装します。
/// </summary>
public static class Vector3Ex
{
    #region Field

    /// <summary>
    /// (0, 0, -1) を示すインスタンス。
    /// </summary>
    public static readonly Vector3 Back = new Vector3(0, 0, -1);

    /// <summary>
    /// (0, -1, 0) を示すインスタンス。
    /// </summary>
    public static readonly Vector3 Down = new Vector3(0, -1, 0);

    /// <summary>
    /// (0, 0, 1) を示すインスタンス。
    /// </summary>
    public static readonly Vector3 Forward = new Vector3(0, 0, 1);

    /// <summary>
    /// (-1, 0, 0) を示すインスタンス。
    /// </summary>
    public static readonly Vector3 Left = new Vector3(-1, 0, 0);

    /// <summary>
    /// (1, 1, 1) を示すインスタンス。
    /// </summary>
    public static readonly Vector3 One = new Vector3(1, 1, 1);

    /// <summary>
    /// (1, 0, 0) を示すインスタンス。
    /// </summary>
    public static readonly Vector3 Right = new Vector3(1, 0, 0);

    /// <summary>
    /// (0, 1, 0) を示すインスタンス。
    /// </summary>
    public static readonly Vector3 Up = new Vector3(0, 1, 0);

    /// <summary>
    /// (0, 0, 0) を示すインスタンス。
    /// </summary>
    public static readonly Vector3 Zero = new Vector3(0, 0, 0);

    #endregion Field

    #region Method

    /// <summary>
    /// ランダムな数値を与えたインスタンスを生成します。
    /// int 型で指定するとき、最小値を含み、最大値は含まれない点に注意してください。
    /// </summary>
    /// <param name="min">最小値。</param>
    /// <param name="max">最大値。</param>
    /// <returns>
    /// ランダムな数値を与えられたインスタンス。
    /// </returns>
    public static Vector3 Random(float min, float max)
    {
        return new Vector3()
        {
            x = UnityEngine.Random.Range(min, max),
            y = UnityEngine.Random.Range(min, max),
            z = UnityEngine.Random.Range(min, max),
        };
    }

    /// <summary>
    /// ランダムな数値を与えたインスタンスを生成します。
    /// int 型で指定するとき、最小値を含み、最大値は含まれない点に注意してください。
    /// </summary>
    /// <param name="min">最小値。</param>
    /// <param name="max">最大値。</param>
    /// <returns>
    /// ランダムな数値を与えられたインスタンス。
    /// </returns>
    public static Vector3 Random(int min, int max)
    {
        return new Vector3()
        {
            x = UnityEngine.Random.Range(min, max),
            y = UnityEngine.Random.Range(min, max),
            z = UnityEngine.Random.Range(min, max),
        };
    }

    /// <summary>
    /// ランダムな数値を与えたインスタンスを生成します。
    /// </summary>
    /// <param name="min">
    /// 最小値。
    /// </param>
    /// <param name="max">
    /// 最大値。
    /// </param>
    /// <returns>
    /// ランダムな数値を与えられたインスタンス。
    /// </returns>
    public static Vector3 Random(Vector3 min, Vector3 max)
    {
        return new Vector3()
        {
            x = UnityEngine.Random.Range(min.x, max.x),
            y = UnityEngine.Random.Range(min.y, max.y),
            z = UnityEngine.Random.Range(min.z, max.z),
        };
    }

    #endregion Method
}