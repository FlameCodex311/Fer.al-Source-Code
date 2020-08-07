/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired.Demos
{
	[AddComponentMenu] // 0x00000001802676D0-0x0000000180267750
	[RequireComponent] // 0x00000001802676D0-0x0000000180267750
	public sealed class UIPointer : UIBehaviour // TypeDefIndex: 9406
	{
		// Fields
		[SerializeField] // 0x00000001802679F0-0x0000000180267A40
		[Tooltip] // 0x00000001802679F0-0x0000000180267A40
		private bool _hideHardwarePointer; // 0x18
		[SerializeField] // 0x0000000180267C90-0x0000000180267CE0
		[Tooltip] // 0x0000000180267C90-0x0000000180267CE0
		private bool _autoSort; // 0x19
		[NonSerialized]
		private RectTransform _canvasRectTransform; // 0x20
	
		// Properties
		public bool autoSort { get; set; } // 0x0000000180690340-0x0000000180690350 0x000000018106F3B0-0x000000018106F3F0
	
		// Constructors
		public UIPointer(); // 0x000000018106F3A0-0x000000018106F3B0
	
		// Methods
		protected override void Awake(); // 0x000000018106EE20-0x000000018106EFD0
		private void Update(); // 0x000000018106F300-0x000000018106F3A0
		protected override void OnTransformParentChanged(); // 0x000000018106F0B0-0x000000018106F0D0
		protected override void OnCanvasGroupChanged(); // 0x000000018106F0B0-0x000000018106F0D0
		public void OnScreenPositionChanged(Vector2 screenPosition); // 0x000000018106F0D0-0x000000018106F300
		private void GetDependencies(); // 0x000000018106EFD0-0x000000018106F0B0
	}
}
