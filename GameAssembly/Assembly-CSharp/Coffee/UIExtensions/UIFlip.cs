/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Coffee.UIExtensions
{
	[AddComponentMenu] // 0x00000001800F9440-0x00000001800F94D0
	[DisallowMultipleComponent] // 0x00000001800F9440-0x00000001800F94D0
	[RequireComponent] // 0x00000001800F9440-0x00000001800F94D0
	public class UIFlip : BaseMeshEffect // TypeDefIndex: 15505
	{
		// Fields
		[SerializeField] // 0x00000001800F9780-0x00000001800F97D0
		[Tooltip] // 0x00000001800F9780-0x00000001800F97D0
		private bool m_Horizontal; // 0x20
		[SerializeField] // 0x00000001800F99B0-0x00000001800F9A00
		[Tooltip] // 0x00000001800F99B0-0x00000001800F9A00
		private bool m_Veritical; // 0x21
	
		// Properties
		public bool horizontal { get; set; } // 0x00000001803C19E0-0x00000001803C19F0 0x00000001804231D0-0x00000001804231E0
		public bool vertical { get; set; } // 0x00000001803C19F0-0x00000001803C1A00 0x00000001804D5390-0x00000001804D53A0
	
		// Constructors
		public UIFlip(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		public override void ModifyMesh(VertexHelper vh); // 0x0000000181486A70-0x0000000181486C40
	}
}
