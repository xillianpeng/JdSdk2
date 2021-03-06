﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Cps;

namespace JdSdk.Request.Cps
{
﻿    public class UnionZoneInfoGetRequest : JdRequestBase<UnionZoneInfoGetResponse>
    {
        public Nullable<Int64> ZoneId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.union.zone.info.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("zone_id" ,this.ZoneId);
        }

    }

}
