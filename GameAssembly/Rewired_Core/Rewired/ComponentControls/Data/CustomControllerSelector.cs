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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001800C10A0-0x00000001800C10D0
	public sealed class CustomControllerSelector // TypeDefIndex: 5811
	{
		// Fields
		[CustomObfuscation] // 0x00000001801474C0-0x0000000180147520
		[SerializeField] // 0x00000001801474C0-0x0000000180147520
		[Tooltip] // 0x00000001801474C0-0x0000000180147520
		private bool _findUsingSourceId; // 0x10
		[CustomObfuscation] // 0x0000000180147880-0x0000000180147900
		[FieldRange] // 0x0000000180147880-0x0000000180147900
		[SerializeField] // 0x0000000180147880-0x0000000180147900
		[Tooltip] // 0x0000000180147880-0x0000000180147900
		private int _sourceId; // 0x14
		[CustomObfuscation] // 0x0000000180147E10-0x0000000180147E70
		[SerializeField] // 0x0000000180147E10-0x0000000180147E70
		[Tooltip] // 0x0000000180147E10-0x0000000180147E70
		private bool _findUsingTag; // 0x18
		[CustomObfuscation] // 0x0000000180148240-0x00000001801482A0
		[SerializeField] // 0x0000000180148240-0x00000001801482A0
		[Tooltip] // 0x0000000180148240-0x00000001801482A0
		private string _tag; // 0x20
		[CustomObfuscation] // 0x0000000180148600-0x0000000180148660
		[SerializeField] // 0x0000000180148600-0x0000000180148660
		[Tooltip] // 0x0000000180148600-0x0000000180148660
		private bool _findInPlayer; // 0x28
		[CustomObfuscation] // 0x0000000180148AB0-0x0000000180148B10
		[SerializeField] // 0x0000000180148AB0-0x0000000180148B10
		[Tooltip] // 0x0000000180148AB0-0x0000000180148B10
		private int _playerId; // 0x2C
	
		// Properties
		public bool findUsingSourceId { get; set; } // 0x0000000180375540-0x0000000180375550 0x0000000181436B70-0x0000000181436B80
		public int sourceId { get; set; } // 0x0000000180372360-0x0000000180372370 0x0000000181436BA0-0x0000000181436BD0
		public bool findUsingTag { get; set; } // 0x000000018041BAC0-0x000000018041BAD0 0x0000000181436B80-0x0000000181436B90
		public string tag { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x0000000181436BD0-0x0000000181436C30
		public bool findInPlayer { get; set; } // 0x00000001803A2790-0x00000001803A27A0 0x0000000181436B60-0x0000000181436B70
		public int playerId { get; set; } // 0x000000018038E0D0-0x000000018038E0E0 0x0000000181436B90-0x0000000181436BA0
	
		// Constructors
		public CustomControllerSelector(); // 0x000000018075C3F0-0x000000018075C400
	
		// Methods
		internal CustomController GetCustomController(); // 0x0000000181436780-0x0000000181436B60
		private void cmtbuFqVYbwoFNiprYsdGZCxOJZ(); // 0x00000001803581E0-0x00000001803581F0
	}
}
