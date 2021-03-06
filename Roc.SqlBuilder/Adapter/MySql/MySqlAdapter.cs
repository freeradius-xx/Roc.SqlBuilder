﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roc.SqlBuilder.Adapter
{
    class MySqlAdapter : AdapterBase
    {
        public MySqlAdapter()
            : base(SqlConst.LeftTokens[1], SqlConst.RightTokens[1], SqlConst.ParamPrefixs[2])
        {

        }

        public override string QueryPage(SqlEntity entity)
        {
            int pageSize = entity.PageSize;
            int limit = pageSize * (entity.PageNumber - 1);

            return string.Format("SELECT {0} FROM {1} {2} {3} LIMIT {4},{5}", entity.Selection, entity.TableName, entity.Conditions, entity.OrderBy, limit, pageSize);
        }
    }
}
