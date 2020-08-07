/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Coffee.UIExtensions
{
	[AddComponentMenu] // 0x0000000180207280-0x0000000180207310
	[DisallowMultipleComponent] // 0x0000000180207280-0x0000000180207310
	[RequireComponent] // 0x0000000180207280-0x0000000180207310
	public class UIFlip : BaseMeshEffect // TypeDefIndex: 16344
	{
		// Fields
		[SerializeField] // 0x00000001802076F0-0x0000000180207740
		[Tooltip] // 0x00000001802076F0-0x0000000180207740
		private bool m_Horizontal; // 0x20
		[SerializeField] // 0x0000000180207A90-0x0000000180207AE0
		[Tooltip] // 0x0000000180207A90-0x0000000180207AE0
		private bool m_Veritical; // 0x21
	
		// Properties
		public bool horizontal { get; set; } // 0x00000001803FA090-0x00000001803FA0A0 0x00000001803FA0B0-0x00000001803FA0C0
		public bool vertical { get; set; } // 0x00000001804F2E80-0x00000001804F2E90 0x000000018078CA00-0x000000018078CA10
	
		// Constructors
		public UIFlip(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		public override void ModifyMesh(VertexHelper vh); // 0x000000018078C830-0x000000018078CA00
	}
}
