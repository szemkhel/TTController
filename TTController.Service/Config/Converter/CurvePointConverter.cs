﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TTController.Common;

namespace TTController.Service.Config.Converter
{
    public class CurvePointConverter : ObjectToArrayConverter<CurvePoint> {
        protected override object[] CreateConstructorArgs(JArray array) =>
            new object[] {array[0].Value<int>(), array[1].Value<int>()};
    }
}
