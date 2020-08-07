/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech
{
	[RequireComponent] // 0x0000000180267290-0x00000001802672E0
	public class EditorVisibleVolume : MonoBehaviour // TypeDefIndex: 14561
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color _volumeColor; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _shouldRender; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _shouldRenderOnlyWhenSelected; // 0x31
		private BoxCollider _collider; // 0x38
	
		// Properties
		public Color VolumeColor { get; set; } // 0x00000001804A4210-0x00000001804A4220 0x0000000180CB18D0-0x0000000180CB18E0
	
		// Constructors
		public EditorVisibleVolume(); // 0x0000000180CB1870-0x0000000180CB18D0
	}
}
