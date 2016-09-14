﻿/*******************************************************************************
 * Copyright © 2016 NFine.Framework 版权所有
 * Author: NFine
 * Description: NFine快速开发平台
 * Website：http://www.nfine.cn
*********************************************************************************/
using Evolution.Data.Entity;
using System;

namespace Evolution.Domain.Entity.SystemManage
{
    public class ModuleButtonEntity : EntityBase, ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public string ModuleId { get; set; }
        public string ParentId { get; set; }
        public int? Layers { get; set; }
        public string EnCode { get; set; }
        public string FullName { get; set; }
        public string Icon { get; set; }
        public int? Location { get; set; }
        public string JsEvent { get; set; }
        public string UrlAddress { get; set; }
        public bool? Split { get; set; }
        public bool? IsPublic { get; set; }
        public bool? AllowEdit { get; set; }
        public bool? AllowDelete { get; set; }
    }
}
