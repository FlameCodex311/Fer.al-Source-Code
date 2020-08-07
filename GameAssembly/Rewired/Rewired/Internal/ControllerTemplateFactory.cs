/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired.Internal
{
	public static class ControllerTemplateFactory // TypeDefIndex: 9379
	{
		// Fields
		private static readonly Type[] _defaultTemplateTypes; // 0x00
		private static readonly Type[] _defaultTemplateInterfaceTypes; // 0x08
	
		// Properties
		public static Type[] templateTypes { get; } // 0x00000001820C4F20-0x00000001820C4F80 
		public static Type[] templateInterfaceTypes { get; } // 0x00000001820C4EC0-0x00000001820C4F20 
	
		// Constructors
		static ControllerTemplateFactory(); // 0x00000001820C49B0-0x00000001820C4EC0
	
		// Methods
		public static IControllerTemplate Create(Guid typeGuid, object payload); // 0x00000001820C45F0-0x00000001820C49B0
	}
}
