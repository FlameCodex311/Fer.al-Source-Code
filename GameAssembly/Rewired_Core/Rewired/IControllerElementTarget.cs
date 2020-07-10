﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	public interface IControllerElementTarget // TypeDefIndex: 5982
	{
		// Properties
		int elementIdentifierId { get; }
		AxisRange axisRange { get; }
		bool hasTarget { get; }
		ControllerElementType elementType { get; }
		string descriptiveName { get; }
		Controller controller { get; }
		Controller.Element element { get; }
	}
}