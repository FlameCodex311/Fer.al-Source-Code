/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace FancyScrollView
{
	public class Example02ScrollViewCell : FancyScrollViewCell<FancyScrollView.Example02CellDto, FancyScrollView.Example02ScrollViewContext> // TypeDefIndex: 14308
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Animator animator; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private UnityEngine.UI.Text message; // 0x38
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Image image; // 0x40
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Button button; // 0x48
		private static readonly int scrollTriggerHash; // 0x00
		private float currentPosition; // 0x50
	
		// Constructors
		public Example02ScrollViewCell(); // 0x0000000180E202F0-0x0000000180E20330
		static Example02ScrollViewCell(); // 0x0000000180E202A0-0x0000000180E202F0
	
		// Methods
		private void Start(); // 0x0000000180E20050-0x0000000180E200E0
		public override void UpdateContent(Example02CellDto itemData); // 0x0000000180E200E0-0x0000000180E201E0
		public override void UpdatePosition(float position); // 0x0000000180E201E0-0x0000000180E202A0
		private void OnPressedCell(); // 0x0000000180E1FFF0-0x0000000180E20050
		private void OnEnable(); // 0x0000000180E1FFD0-0x0000000180E1FFF0
	}
}
