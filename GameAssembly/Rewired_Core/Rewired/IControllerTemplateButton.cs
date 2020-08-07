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
	public interface IControllerTemplateButton : IControllerTemplateElement // TypeDefIndex: 6113
	{
		// Properties
		bool value { get; }
		bool valuePrev { get; }
		float pressure { get; }
		float pressurePrev { get; }
		bool justPressed { get; }
		bool justReleased { get; }
		bool justChangedState { get; }
		IControllerTemplateButtonSource source { get; }
		IControllerTemplateAxis AsAxis { get; }
	}
}
