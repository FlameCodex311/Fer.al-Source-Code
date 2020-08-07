/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Attributes;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001801DDE50-0x00000001801DDE80
	public sealed class CustomControllerSelector // TypeDefIndex: 5970
	{
		// Fields
		[CustomObfuscation] // 0x00000001801E3920-0x00000001801E3980
		[SerializeField] // 0x00000001801E3920-0x00000001801E3980
		[Tooltip] // 0x00000001801E3920-0x00000001801E3980
		private bool _findUsingSourceId; // 0x10
		[CustomObfuscation] // 0x00000001801E3C40-0x00000001801E3CC0
		[FieldRange] // 0x00000001801E3C40-0x00000001801E3CC0
		[SerializeField] // 0x00000001801E3C40-0x00000001801E3CC0
		[Tooltip] // 0x00000001801E3C40-0x00000001801E3CC0
		private int _sourceId; // 0x14
		[CustomObfuscation] // 0x00000001801E3FF0-0x00000001801E4050
		[SerializeField] // 0x00000001801E3FF0-0x00000001801E4050
		[Tooltip] // 0x00000001801E3FF0-0x00000001801E4050
		private bool _findUsingTag; // 0x18
		[CustomObfuscation] // 0x00000001801E43B0-0x00000001801E4410
		[SerializeField] // 0x00000001801E43B0-0x00000001801E4410
		[Tooltip] // 0x00000001801E43B0-0x00000001801E4410
		private string _tag; // 0x20
		[CustomObfuscation] // 0x00000001801E4A00-0x00000001801E4A60
		[SerializeField] // 0x00000001801E4A00-0x00000001801E4A60
		[Tooltip] // 0x00000001801E4A00-0x00000001801E4A60
		private bool _findInPlayer; // 0x28
		[CustomObfuscation] // 0x00000001801E4D60-0x00000001801E4DC0
		[SerializeField] // 0x00000001801E4D60-0x00000001801E4DC0
		[Tooltip] // 0x00000001801E4D60-0x00000001801E4DC0
		private int _playerId; // 0x2C
	
		// Properties
		public bool findUsingSourceId { get; set; } // 0x00000001803FD450-0x00000001803FD460 0x0000000180914520-0x0000000180914530
		public int sourceId { get; set; } // 0x00000001803FD2F0-0x00000001803FD300 0x0000000180914550-0x0000000180914580
		public bool findUsingTag { get; set; } // 0x00000001803F6D30-0x00000001803F6D40 0x0000000180914530-0x0000000180914540
		public string tag { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x0000000180914580-0x00000001809145E0
		public bool findInPlayer { get; set; } // 0x00000001804C6790-0x00000001804C67A0 0x0000000180914510-0x0000000180914520
		public int playerId { get; set; } // 0x000000018043C670-0x000000018043C680 0x0000000180914540-0x0000000180914550
	
		// Constructors
		public CustomControllerSelector(); // 0x00000001808A18F0-0x00000001808A1900
	
		// Methods
		internal CustomController GetCustomController(); // 0x0000000180914140-0x0000000180914510
		private void cmtbuFqVYbwoFNiprYsdGZCxOJZ(); // 0x00000001803774A0-0x00000001803774B0
	}
}
