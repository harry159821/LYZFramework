﻿/*******************************************************************************
* 版权声明：北京润尼尔网络科技有限公司，保留所有版权
* 版本声明：v1.0.0
* 项目名称：Buskit3D
* 类 名 称：CommonDataModel
* 创建日期：2019-03-31 14:30:17
* 作者名称：王志远
* CLR 版本：4.0.30319.42000
* 功能描述：实体类工具，用来查找一个GameObject上的实体对象、数据模型、业务逻辑
* 修改记录：
* 日期 描述：
* 
******************************************************************************/

using Com.Rainier.Buskit3D;
using UnityEngine;

namespace Buskit3D.Training.IoC.E
{
    /// <summary>
    /// 豆柏实体数据
    /// </summary>
    public class DouEntity : BaseDataModelEntity
    {
        public string tipText = "";

        public Vector3 localPostion = Vector3.one;

        public bool visible = true;
    }
}


