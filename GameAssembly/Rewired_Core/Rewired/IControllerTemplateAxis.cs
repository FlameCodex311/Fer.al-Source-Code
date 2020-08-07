/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	public interface IControllerTemplateAxis : IControllerTemplateElement // TypeDefIndex: 6112
	{
		// Properties
		string positiveDescriptiveName { get; }
		string negativeDescriptiveName { get; }
		float value { get; }
		float valuePrev { get; }
		IControllerTemplateAxisSource source { get; }
		IControllerTemplateButton AsButton { get; }
	
		// Methods
		string GetDescriptiveName(AxisRange axisRange);
	}
}
