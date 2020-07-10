/*
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
	public sealed class CustomControllerMap : ControllerMapWithAxes // TypeDefIndex: 6525
	{
		// Fields
		private int _sourceControllerId; // 0x80
	
		// Properties
		public int sourceControllerId { get; set; } // 0x00000001804241F0-0x0000000180424200 0x0000000180423A40-0x0000000180423A50
	
		// Constructors
		public CustomControllerMap(); // 0x00000001805E5340-0x00000001805E5350
		public CustomControllerMap(CustomControllerMap customControllerMap); // 0x00000001805E5350-0x00000001805E5390
	
		// Methods
		internal void SetIdentity(int sourceControllerId, int categoryId, int layoutId); // 0x00000001805E5330-0x00000001805E5340
		internal static CustomControllerMap Blank(int sourceControllerId, int categoryId, int layoutId); // 0x00000001805E52A0-0x00000001805E5330
	}
}
