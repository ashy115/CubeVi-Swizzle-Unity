using System;
using System.Collections.Generic;
using UnityEngine;

namespace CubeVi_Swizzle
{
    public class DeviceData
    {
        public string name;
        public int imgs_count_x;
        public int imgs_count_y;
        public int viewnum;
        public float theta;
        public float output_size_X;
        public float output_size_Y;
        public int subimg_width;
        public int subimg_height;
        public float f_cam;
        public float tan_alpha_2;
        public float x0;
        public float interval;
        public float slope;
        public float nearrate;
        public float farrate;
    }

    [System.Serializable]
    public class SwizzleConfig
    {
        public float lineNumber;
        public float obliquity;
        public float deviation;
    }

    [System.Serializable]
    public class DeviceConfig
    {
        public SwizzleConfig config;
    }

    [System.Serializable]
    public class JsonWrapper
    {
        public string config;
    }
}