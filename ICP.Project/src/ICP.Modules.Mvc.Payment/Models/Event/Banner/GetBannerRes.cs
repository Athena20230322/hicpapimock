﻿namespace ICP.Modules.Mvc.Payment.Models.Event.Banner
{
    /// <summary>
    /// 取得廣告Res
    /// </summary>
    public class GetBannerRes
    {
        /// <summary>
        /// 廣告編號
        /// </summary>
        public int BannerID { get; set; }

        /// <summary>
        /// 廣告標題
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 圖片路徑
        /// </summary>
        public string ImagePath { get; set; }
       
        /// <summary>
        /// 廣告內容
        /// </summary>
        public string BannerContent { get; set; }

        /// <summary>
        /// 廣告連結
        /// </summary>
        public string UrlLink { get; set; }

        /// <summary>
        /// 頁面開啟設定
        /// </summary>
        /// <remarks>0內開 1外開</remarks>
        public int? OpenNewWindow { get; set; }
    }
}
