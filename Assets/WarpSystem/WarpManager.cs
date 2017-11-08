using System.Collections.Generic;
using UnityEngine;

namespace WarpSystem
{
    /// <summary>
    /// ワープを管理します。
    /// </summary>
    public class WarpManager : MonoBehaviour
    {
        // NOTE:
        // 実装例で、必ずしも利用する必要はありません。

        #region Field

        /// <summary>
        /// オブジェクトが通りうるすべてのワープゲート。
        /// </summary>
        public WarpGate[] warpGates;

        /// <summary>
        /// ワープするオブジェクト。
        /// </summary>
        public List<WarpObject> warpObjects;

        #endregion Field

        #region Method

        /// <summary>
        /// 更新時に呼び出されます。
        /// </summary>
        protected virtual void Update()
        {
            foreach (WarpObject warpObject in this.warpObjects)
            {
                foreach (WarpGate warpGate in this.warpGates)
                {
                    warpObject.Warp(warpGate);
                }
            }
        }

        #endregion Method
    }
}