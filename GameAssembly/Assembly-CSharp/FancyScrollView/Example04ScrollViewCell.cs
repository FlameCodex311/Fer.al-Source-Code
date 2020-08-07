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
	public class Example04ScrollViewCell : FancyScrollViewCell<FancyScrollView.Example04CellDto, FancyScrollView.Example04ScrollViewContext> // TypeDefIndex: 14320
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private UnityEngine.UI.Text message; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Image image; // 0x38
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Button button; // 0x40
		private float currentPosition; // 0x48
	
		// Constructors
		public Example04ScrollViewCell(); // 0x0000000180E215D0-0x0000000180E21610
	
		// Methods
		private void Start(); // 0x0000000180E21150-0x0000000180E211E0
		public override void UpdateContent(Example04CellDto itemData); // 0x0000000180E211E0-0x0000000180E212E0
		public override void UpdatePosition(float position); // 0x0000000180E212E0-0x0000000180E215D0
		private void OnPressedCell(); // 0x0000000180E210F0-0x0000000180E21150
		private void OnEnable(); // 0x0000000180E210D0-0x0000000180E210F0
	}
}
