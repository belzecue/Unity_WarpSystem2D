using UnityEngine;

/// <summary>
/// GameObject 型の拡張メソッドやユーティリティメソッドを実装します。
/// </summary>
public static class GameObjectEx
{
    /// <summary>
    /// この GameObject に追加されたコンポーネントから、指定した型のコンポーネントのみを削除します。
    /// GetComponent を伴うため非常に負荷が大きい点に注意して下さい。
    /// </summary>
    /// <typeparam name="T">
    /// Component Type.
    /// </typeparam>
    /// <param name="gameObject">
    /// GameObject.
    /// </param>
    public static void RemoveComponent<T>(this GameObject gameObject) where T : Component
    {
        GameObject.Destroy(gameObject.GetComponent<T>());
    }

    /// <summary>
    /// この GameObject に追加された、すべての Component を削除します。
    /// GetComponent を伴うため非常に負荷が大きい点に注意して下さい。
    /// </summary>
    /// <param name="gameObject">
    /// GameObject.
    /// </param>
    public static void RemoveAllComponent(this GameObject gameObject)
    {
        Component[] components = gameObject.GetComponents<Component>();

        for (int i = 0; i < components.Length; i++)
        {
            GameObject.Destroy(components[i]);
        }
    }

    /// <summary>
    /// MaterialPropertyBlock を利用して "_Color" の値を設定します。
    /// GetComponent を伴うため非常に負荷が大きい点に注意して下さい。
    /// </summary>
    /// <param name="gameObject">
    /// GameObject.
    /// </param>
    /// <param name="color">
    /// "_Color" に設定する色。
    /// </param>
    public static void SetColor(this GameObject gameObject, Color color)
    {
        MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();

        Renderer renderer = gameObject.GetComponent<Renderer>();

        renderer.GetPropertyBlock(materialPropertyBlock);

        materialPropertyBlock.SetColor("_Color", color);

        renderer.SetPropertyBlock(materialPropertyBlock);
    }
}