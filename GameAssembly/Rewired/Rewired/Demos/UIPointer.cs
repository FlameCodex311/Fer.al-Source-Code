/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired.Demos
{
	[AddComponentMenu] // 0x0000000180105B70-0x0000000180105BF0
	[RequireComponent] // 0x0000000180105B70-0x0000000180105BF0
	public sealed class UIPointer : UIBehaviour // TypeDefIndex: 9240
	{
		// Fields
		[SerializeField] // 0x0000000180105EC0-0x0000000180105F10
		[Tooltip] // 0x0000000180105EC0-0x0000000180105F10
		private bool _hideHardwarePointer; // 0x18
		[SerializeField] // 0x00000001801060F0-0x0000000180106140
		[Tooltip] // 0x00000001801060F0-0x0000000180106140
		private bool _autoSort; // 0x19
		[NonSerialized]
		private RectTransform _canvasRectTransform; // 0x20
	
		// Properties
		public bool autoSort { get; set; } // 0x000000018048F440-0x000000018048F450 0x0000000181BCD220-0x0000000181BCD260
	
		// Constructors
		public UIPointer(); // 0x0000000181BCD210-0x0000000181BCD220
	
		// Methods
		protected override void Awake(); // 0x0000000181BCCD30-0x0000000181BCCE30
		private void Update(); // 0x0000000181BCD170-0x0000000181BCD210
		protected override void OnTransformParentChanged(); // 0x0000000181BCCF10-0x0000000181BCCF30
		protected override void OnCanvasGroupChanged(); // 0x0000000181BCCF10-0x0000000181BCCF30
		public void OnScreenPositionChanged(Vector2 screenPosition); // 0x0000000181BCCF30-0x0000000181BCD170
		private void GetDependencies(); // 0x0000000181BCCE30-0x0000000181BCCF10
	}
}
