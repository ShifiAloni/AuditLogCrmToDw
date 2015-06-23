﻿using Crm.ImportAuditLog.DataModel;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.ImportAuditLog.Bll
{
    public class PicklistFieldValue : FieldValueBase
    {

        public PicklistFieldValue(Action<string> log)
            : base(log)
        {
          
        }

        public override CrmValueAttrbite GetValue(string key, Entity entity)
        {
            var val = base.GetValue(key, entity);
            if (entity.Contains(key) && entity[key] != null && entity[key] is OptionSetValue)
            {
                val.FieldValue = entity.GetAttributeValue<OptionSetValue>(key).Value.ToString();
            }
            return val;
        }
    }
}
