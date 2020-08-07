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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001802111C0-0x0000000180211200
	[Preserve] // 0x00000001802111C0-0x0000000180211200
	public sealed class ControllerMapLayoutManager_Rule_Editor : IDeepCloneable // TypeDefIndex: 6660
	{
		// Fields
		[Serialize] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private string _tag; // 0x10
		[Serialize] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private List<int> _categoryIds; // 0x18
		[Serialize] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private int _layoutId; // 0x20
		[Serialize] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private ControllerSetSelector_Editor _controllerSetSelector; // 0x28
	
		// Properties
		public string tag { get; set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
		public List<int> categoryIds { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public int layoutId { get; set; } // 0x00000001803FB670-0x00000001803FB680 0x00000001804556D0-0x00000001804556E0
		public ControllerSetSelector_Editor controllerSetSelector { get; set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
	
		// Constructors
		public ControllerMapLayoutManager_Rule_Editor(); // 0x0000000180D7FF20-0x0000000180D7FFB0
		public ControllerMapLayoutManager_Rule_Editor(ControllerMapLayoutManager_Rule_Editor source); // 0x0000000180D7FE50-0x0000000180D7FF20
	
		// Methods
		internal ControllerMapLayoutManager.Rule ToRuntime(); // 0x0000000180D7FD80-0x0000000180D7FE50
		object IDeepCloneable.DeepClone(); // 0x0000000180D7FC80-0x0000000180D7FD80
	}
}
