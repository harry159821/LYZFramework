﻿/*******************************************************************************
* 版权声明：北京润尼尔网络科技有限公司，保留所有版权
* 版本声明：v1.0.0
* 类 名 称： SettingLinkViewModel
* 创建日期：2019-04-11 09:52:07
* 作者名称：高大旺
* CLR 版本：4.0.30319.42000
* 修改记录：
* 描述：
******************************************************************************/

using Com.Rainier.Buskit3D;

namespace Buskit3D.Example_046_Communication
{
	/// <summary>
    /// 
    /// </summary>
	public class SettingLinkViewModel : ViewModelBehaviour
	{
        [Binding(EntityPropertyName = "dropdown")]
        public DropdownView toweName;
        [Binding(EntityPropertyName = "linkList")]
        public TextView linkList;
        [Binding(EntityPropertyName = "btnSure")]
        public ButtonView btnSure;

        protected override void Awake()
        {
            this.DataEntity = new SettingLinkEntity();
            base.Awake();
        }
    }
}

