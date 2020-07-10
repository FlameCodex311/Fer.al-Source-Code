/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace FancyScrollView
{
	public class Example04ScrollViewCell : FancyScrollViewCell<FancyScrollView.Example04CellDto, FancyScrollView.Example04ScrollViewContext> // TypeDefIndex: 15873
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private UnityEngine.UI.Text message; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Image image; // 0x38
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Button button; // 0x40
		private float currentPosition; // 0x48
	
		// Constructors
		public Example04ScrollViewCell(); // 0x000000018148DED0-0x000000018148DF10
	
		// Methods
		private void Start(); // 0x000000018148DA30-0x000000018148DAD0
		public override void UpdateContent(Example04CellDto itemData); // 0x000000018148DAD0-0x000000018148DBD0
		public override void UpdatePosition(float position); // 0x000000018148DBD0-0x000000018148DED0
		private void OnPressedCell(); // 0x000000018148D9D0-0x000000018148DA30
		private void OnEnable(); // 0x000000018148D9B0-0x000000018148D9D0
	}
}
