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
	public sealed class CustomControllerMap : ControllerMapWithAxes // TypeDefIndex: 6684
	{
		// Fields
		private int _sourceControllerId; // 0x80
	
		// Properties
		public int sourceControllerId { get; set; } // 0x000000018082F980-0x000000018082F990 0x000000018082F210-0x000000018082F220
	
		// Constructors
		public CustomControllerMap(); // 0x0000000180D84580-0x0000000180D84590
		public CustomControllerMap(CustomControllerMap customControllerMap); // 0x0000000180D84590-0x0000000180D845D0
	
		// Methods
		internal void SetIdentity(int sourceControllerId, int categoryId, int layoutId); // 0x0000000180D84570-0x0000000180D84580
		internal static CustomControllerMap Blank(int sourceControllerId, int categoryId, int layoutId); // 0x0000000180D844E0-0x0000000180D84570
	}
}
