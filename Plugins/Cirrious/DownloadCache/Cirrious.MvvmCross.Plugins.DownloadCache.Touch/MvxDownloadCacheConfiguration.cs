// MvxDownloadCacheConfiguration.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System;
using Cirrious.CrossCore.Plugins;

namespace Cirrious.MvvmCross.Plugins.DownloadCache.Touch
{
    public class MvxDownloadCacheConfiguration
        : IMvxPluginConfiguration
    {
        public static readonly MvxDownloadCacheConfiguration Default = new MvxDownloadCacheConfiguration();

        public string CacheName { get; set; }
        public string CacheFolderPath { get; set; }
        public int MaxFiles { get; set; }
        public TimeSpan MaxFileAge { get; set; }
        public int MaxInMemoryFiles { get; set; }
        public int MaxInMemoryBytes { get; set; }

        public MvxDownloadCacheConfiguration()
        {
            CacheName = "Pictures.MvvmCross";
            CacheFolderPath = "../Library/Caches/Pictures.MvvmCross/";
            MaxFiles = 500;
            MaxFileAge = TimeSpan.FromDays(7);
            MaxInMemoryBytes = 4000000; // 4 MB
            MaxInMemoryFiles = 30;
        }
    }
}