/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	public interface IControllerTemplate // TypeDefIndex: 6090
	{
		// Properties
		Controller controller { get; }
		string name { get; }
		Guid typeGuid { get; }
		IList<IControllerTemplateElement> elements { get; }
		int elementCount { get; }
	
		// Methods
		IControllerTemplateElement GetElement(int id);
		T GetElement<T>(int id)
			where T : class, IControllerTemplateElement;
		int GetElementTargets(ControllerElementTarget target, IList<ControllerTemplateElementTarget> results);
	}
}
