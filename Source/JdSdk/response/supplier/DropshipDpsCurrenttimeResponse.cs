﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Supplier
{
﻿    [Serializable]
    public class DropshipDpsCurrenttimeResponse : JdResponse
    {
        [JsonProperty("currentTime")]
        public Nullable<DateTime> CurrentTime
        {
            get;
            set;
        }

    }

}
