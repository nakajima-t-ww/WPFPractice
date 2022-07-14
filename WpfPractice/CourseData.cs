// Copyright © 2022 Tsubasa co., Ltd. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WpfPractice
{
    /// <summary>
    /// とりあえずのルート要素
    /// </summary>
    public class CourseDataRoot
    {
        public string? version { get; set; }
        public CourseData[]? course_list { get; set; }
    }

    /// <summary>
    /// 学科情報
    /// </summary>
    public class CourseData
    {
        public string? course_code { get; set; }
        public string? course_name { get; set; }
        public string? course_id { get; set; }
        public SpecialtyData[]? kinds { get; set; }
        public object[]? examination { get; set; }
    }

    /// <summary>
    /// 楽器などの専門情報
    /// </summary>
    public class SpecialtyData
    {
        public string? kind_code { get; set; }
        public string? kind_name { get; set; }
        public string? kind_id { get; set; }
    }
}
