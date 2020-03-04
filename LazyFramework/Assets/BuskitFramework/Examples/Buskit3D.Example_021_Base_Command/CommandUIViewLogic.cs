﻿/*******************************************************************************
* 版权声明：北京润尼尔网络科技有限公司，保留所有版权
* 版本声明：v1.0.0
* 项目名称：Buskit3D
* 类 名 称：SpeedDataModel
* 创建日期：2018-04-07 10:58:17
* 作者名称：黎特为
* CLR 版本：4.0.30319.42000
* 功能描述：接收Slider值变化，作为事件源向所有监听对象发送数值变化事件
* 修改记录：
* 日期 描述 更新功能
* 
******************************************************************************/
using Com.Rainier.Buskit.Unity.Architecture.Aop;
using Com.Rainier.Buskit.Unity.Architecture.Injector;
using UnityEngine;

namespace Com.Rainier.Buskit3D.Example_021
{
    /// <summary>
    /// Cube旋转触发器类
    /// </summary>
    public class CommandUIViewLogic : LogicBehaviour
    {     

        public override void ProcessLogic(PropertyMessage evt)
        {
            switch (evt.PropertyName) {

                case "btnCreate":
                    if (evt.OldValue == evt.NewValue) return;
                    UIController.instance.OnCreate();
                    break;
                case "btnColor":
                    if (evt.OldValue == evt.NewValue) return;
                    UIController.instance.OnChangeColor();
                    break;
                case "btnDelete":
                    if (evt.OldValue == evt.NewValue) return;
                    UIController.instance.OnDelete();
                    break;
                case "btnUndo":
                    if (evt.OldValue == evt.NewValue) return;
                    UIController.instance.OnUndo();
                    break;
                case "btnRedo":
                    if (evt.OldValue == evt.NewValue) return;
                    UIController.instance.OnRedo();
                    break;
                case "rotationSlider":
                    UIController.instance.OnChangValue((float)evt.NewValue);
                    break;
            }

        }
    }
}

