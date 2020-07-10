/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace FancyScrollView
{
	public class Example02ScrollView : FancyScrollView<FancyScrollView.Example02CellDto, FancyScrollView.Example02ScrollViewContext> // TypeDefIndex: 15860
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ScrollPositionController scrollPositionController; // 0x60
	
		// Constructors
		public Example02ScrollView(); // 0x000000018148CE10-0x000000018148CE50
	
		// Methods
		private void Awake(); // 0x000000018148CBD0-0x000000018148CCB0
		public void UpdateData(List<Example02CellDto> data); // 0x000000018148CD90-0x000000018148CE10
		private void OnPressedCell(Example02ScrollViewCell cell); // 0x000000018148CCB0-0x000000018148CD40
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <Awake>b__1_0(float p); // 0x000000018148CD40-0x000000018148CD90
	}
}
