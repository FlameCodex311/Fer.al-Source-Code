/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired.Internal
{
	public static class ControllerTemplateFactory // TypeDefIndex: 9213
	{
		// Fields
		private static readonly Type[] _defaultTemplateTypes; // 0x00
		private static readonly Type[] _defaultTemplateInterfaceTypes; // 0x08
	
		// Properties
		public static Type[] templateTypes { get; } // 0x0000000181BBC990-0x0000000181BBC9F0 
		public static Type[] templateInterfaceTypes { get; } // 0x0000000181BBC930-0x0000000181BBC990 
	
		// Constructors
		static ControllerTemplateFactory(); // 0x0000000181BBC3D0-0x0000000181BBC930
	
		// Methods
		public static IControllerTemplate Create(Guid typeGuid, object payload); // 0x0000000181BBC080-0x0000000181BBC3D0
	}
}
