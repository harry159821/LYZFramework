﻿/*******************************************************************************
* 版权声明：北京润尼尔网络科技有限公司，保留所有版权
* 版本声明：v1.0.0
* 类 名 称： TabItemEntity
* 创建日期：2019-03-21 11:03:04
* 作者名称：高大旺
* CLR 版本：4.0.30319.42000
* 修改记录：
* 描述：
******************************************************************************/

using Com.Rainier.Buskit3D;

namespace Buskit3D.Example_36_Mvvm_Bag
{
	/// <summary>
    ///
    /// </summary>
	public class TabItemEntity : BaseDataModelEntity 
	{
        [RestoreFireLogic]
        public bool isOn = false;
	}
}

