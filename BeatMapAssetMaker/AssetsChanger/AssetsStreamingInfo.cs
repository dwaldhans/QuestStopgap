﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeatmapAssetMaker.AssetsChanger
{
    public class AssetsStreamingInfo
    {
        public AssetsStreamingInfo()
        { }

        public AssetsStreamingInfo(AssetsReader reader)
        {
            Parse(reader);
        }

        private void Parse(AssetsReader reader)
        {
            offset = reader.ReadUInt32();
            size = reader.ReadUInt32();
            path = reader.ReadString();
            //maybe?  assuming it needs to be aligned?
            reader.AlignToObjectData(4);
        }

        public void Write(AssetsWriter writer)
        {
            writer.Write(offset);
            writer.Write(size);
            writer.Write(path);
            writer.AlignTo(4);
        }
        public UInt32 offset { get; set; }
        public UInt32 size { get; set; }
        public string path { get; set; }
    }
}
