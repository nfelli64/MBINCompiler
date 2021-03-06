﻿namespace MBINCompiler.Models.Structs
{
    public class GcResourceElement : NMSTemplate // size = 0x2A8
    {
        [NMS(Size = 0x80)]
        public string Filename;
        [NMS(Ignore = true)]
        public long EmptyNode1;
        public GcSeed GenerationSeed;
        [NMS(Size = 0x200)]
        public string AltId;
        public TkProceduralTextureChosenOptionList Texture;
    }
}
