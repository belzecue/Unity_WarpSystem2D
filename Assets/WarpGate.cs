using UnityEngine;

namespace WarpSystem
{
    /// <summary>
    /// ワープゲート。ワープできる領域と、行き先のゲートを定義します。
    /// </summary>
    public class WarpGate : BoundsBehaviour
    {
        #region Field

        /// <summary>
        /// この WarpGate の行き先。
        /// </summary>
        public WarpGate target;

        #endregion Field

        #region Method

        /// <summary>
        /// ワープする位置をマッピングします。
        /// WarpGate(from) 内の点 warpPosition を、WarpGate(to) 内の点にマッピングします。
        /// </summary>
        /// <param name="from">
        /// ワープするときに侵入した WarpGate 。
        /// </param>
        /// <param name="to">
        /// ワープする先になる WarpGate 。
        /// </param>
        /// <param name="warpPosition">
        /// マッピングする座標。
        /// </param>
        /// <returns>
        /// マッピングされた座標。
        /// </returns>
        public static Vector3 MapWarpPosition(WarpGate from, WarpGate to, Vector3 warpPosition)
        {
            // NOTE:
            // いったんスケールは同等のものとして扱う。

            Vector3 fromCenterOriginPosition = warpPosition - from.transform.position;

            fromCenterOriginPosition = (Quaternion.Inverse(from.transform.rotation) * to.transform.rotation) * fromCenterOriginPosition;

            return to.transform.position + fromCenterOriginPosition;
        }

        #endregion Method
    }
}