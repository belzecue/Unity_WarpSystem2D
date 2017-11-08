using UnityEngine;

namespace WarpSystem
{
    /// <summary>
    /// ゲートを使ってワープするオブジェクト。
    /// </summary>
    public class WarpObject : BoundsBehaviourBase
    {
        #region Field

        /// <summary>
        /// 最後にワープした WarpBox 。
        /// </summary>
        protected WarpGate lastWarpGate;

        /// <summary>
        /// ワープできるかどうか。
        /// </summary>
        protected bool isReadyToWarp = true;

        /// <summary>
        /// ワープしたときのイベント。
        /// </summary>
        public WarpEvent warpEvent;

        #endregion Field

        #region Method

        protected virtual void Update()
        {
            UpdateWarpStatus();
        }

        /// <summary>
        /// 更新時に呼び出されます。
        /// </summary>
        //protected override void Update()
        //{
        //    base.Update();
        //    UpdateWarpStatus();
        //}

        /// <summary>
        /// 指定したゲートを使ってワープします。
        /// </summary>
        /// <param name="warpGate">
        /// ワープに使うゲート。
        /// </param>
        /// <returns>
        /// ワープに成功するとき true, 失敗するとき false 。
        /// </returns>
        public bool Warp(WarpGate warpGate)
        {
            if (!IsAbleToWarp(warpGate))
            {
                return false;
            }

            base.transform.position = WarpGate.MapWarpPosition(warpGate, warpGate.target, base.transform.position);
            base.transform.rotation *= (Quaternion.Inverse(warpGate.transform.rotation) * warpGate.target.transform.rotation);

            this.lastWarpGate  = warpGate.target;
            this.isReadyToWarp = false;

            WarpEventInfo eventInfo = new WarpEventInfo(this, warpGate);
            this.warpEvent.Invoke(eventInfo);
            warpGate.warpEvent.Invoke(eventInfo);

            return true;
        }

        /// <summary>
        /// 指定したゲートを使ってワープできるかどうかを検証します。
        /// </summary>
        /// <param name="warpGate">
        /// 検証するゲート。
        /// </param>
        /// <returns>
        /// ワープできるとき true, できないとき false 。
        /// </returns>
        public bool IsAbleToWarp(WarpGate warpGate)
        {
            return warpGate.bounds.Contains(base.Bounds) && this.isReadyToWarp;
        }

        /// <summary>
        /// ワープに関する状態を更新します。
        /// </summary>
        public void UpdateWarpStatus()
        {
            // NOTE:
            // 一度でもゲートの外に出たら、同じゲートからワープできるようにします。

            if (this.isReadyToWarp)
            {
                return;
            }

            if (!this.lastWarpGate.bounds.Contains(base.Bounds))
            {
                this.lastWarpGate  = null;
                this.isReadyToWarp = true;
            };
        }

        #endregion Method
    }
}