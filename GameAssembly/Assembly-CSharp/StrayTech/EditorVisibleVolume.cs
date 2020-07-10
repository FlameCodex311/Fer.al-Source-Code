/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech
{
	[RequireComponent] // 0x000000018013AA90-0x000000018013AAE0
	public class EditorVisibleVolume : MonoBehaviour // TypeDefIndex: 13894
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color _volumeColor; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _shouldRender; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _shouldRenderOnlyWhenSelected; // 0x31
		private BoxCollider _collider; // 0x38
	
		// Properties
		public Color VolumeColor { get; set; } // 0x0000000180CC6480-0x0000000180CC6490 0x0000000180CC6530-0x0000000180CC6540
	
		// Constructors
		public EditorVisibleVolume(); // 0x0000000181352EB0-0x0000000181352F10
	}
}
