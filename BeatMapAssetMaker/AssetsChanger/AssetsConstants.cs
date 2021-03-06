﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeatmapAssetMaker.AssetsChanger
{
    public class AssetsConstants
    {
        public const int MonoBehaviourScriptType = 114;

        public const int AudioClipClassID = 83;

        public const int BeatmapDataSOTypeIndex = 0x0E;

        public const int BeatmapLevelTypeIndex = 0x0F;

        public const int BeatmapLevelCollectionTypeIndex = 0x10;

        public const int Texture2DClassID = 28;

        public const int SpriteClassID = 213;

        public static Guid BeatmapLevelPackScriptHash { get { return new Guid("252e448f-a4c9-c8aa-dabe-c88917b0dc7d"); } }

        public static Guid BeatmapLevelCollectionScriptHash { get { return new Guid("59dd0c93-dbc2-fac4-6745-01914a570ac2"); } }

        public static Guid MainLevelsCollectionHash { get { return new Guid("8398a1c6-7d3b-cc41-e8d7-83cd6a11bfd4"); } }

        public static AssetsPtr BeatmapLevelTypePtr { get { return new AssetsPtr(1, 644); } }

        public static AssetsPtr BeatmapDataTypePtr { get { return new AssetsPtr(1, 1552); } }

        public static AssetsPtr BeatmapLevelCollectionTypePtr { get { return new AssetsPtr(1, 762); } }

        public static AssetsPtr BeatmapLevelPackScriptPtr { get { return new AssetsPtr(1, 1480); } }


    }
}
