/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Attributes;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x000000018016F680-0x000000018016F6C0
	[Preserve] // 0x000000018016F680-0x000000018016F6C0
	public sealed class ControllerMapEnabler_Rule_Editor : IDeepCloneable // TypeDefIndex: 6495
	{
		// Fields
		[Serialize] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private string _tag; // 0x10
		[Serialize] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private bool _enable; // 0x18
		[Serialize] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private List<int> _categoryIds; // 0x20
		[Serialize] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private List<int> _layoutIds; // 0x28
		[Serialize] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private ControllerSetSelector_Editor _controllerSetSelector; // 0x30
	
		// Properties
		public string tag { get; set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
		public bool enable { get; set; } // 0x000000018041BAC0-0x000000018041BAD0 0x000000018048F590-0x000000018048F5A0
		public List<int> categoryIds { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
		public List<int> layoutIds { get; set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
		public ControllerSetSelector_Editor controllerSetSelector { get; set; } // 0x0000000180397720-0x0000000180397730 0x00000001803A2800-0x00000001803A2810
	
		// Constructors
		public ControllerMapEnabler_Rule_Editor(); // 0x00000001805E05C0-0x00000001805E0670
		public ControllerMapEnabler_Rule_Editor(ControllerMapEnabler_Rule_Editor source); // 0x00000001805E0670-0x00000001805E0760
	
		// Methods
		internal ControllerMapEnabler.Rule ToRuntime(); // 0x00000001805E04C0-0x00000001805E05C0
		object IDeepCloneable.DeepClone(); // 0x00000001805E03B0-0x00000001805E04C0
	}
}
