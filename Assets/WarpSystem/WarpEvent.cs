using UnityEngine.Events;

namespace WarpSystem
{
    /// <summary>
    /// ワープしたとき(した後)の情報を定義します。
    /// </summary>
    [System.Serializable]
    public class WarpEventInfo
    {
        #region Field

        /// <summary>
        /// ワープしたオブジェクト。
        /// </summary>
        public WarpObject warpObject;

        /// <summary>
        /// ワープさせたゲート。
        /// </summary>
        public WarpGate warpGate;

        #endregion Field

        #region Constructor

        /// <summary>
        /// 新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="warpObject">
        /// ワープしたオブジェクト。
        /// </param>
        /// <param name="warpGate">
        /// ワープさせたゲート。
        /// </param>
        public WarpEventInfo(WarpObject warpObject, WarpGate warpGate)
        {
            this.warpObject = warpObject;
            this.warpGate = warpGate;
        }

        #endregion Constructor
    }

    /// <summary>
    /// ワープしたときに呼び出されるイベントです。
    /// ワープした後の情報を取得することができます。
    /// </summary>
    [System.Serializable]
    public class WarpEvent : UnityEvent<WarpEventInfo>
    {
    }
}