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
	public class Example03ScrollView : FancyScrollView<FancyScrollView.Example03CellDto, FancyScrollView.Example03ScrollViewContext> // TypeDefIndex: 15866
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ScrollPositionController scrollPositionController; // 0x60
	
		// Constructors
		public Example03ScrollView(); // 0x000000018148D630-0x000000018148D670
	
		// Methods
		private void Awake(); // 0x000000018148D3F0-0x000000018148D4D0
		public void UpdateData(List<Example03CellDto> data); // 0x000000018148D5B0-0x000000018148D630
		private void OnPressedCell(Example03ScrollViewCell cell); // 0x000000018148D4D0-0x000000018148D560
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <Awake>b__1_0(float p); // 0x000000018148D560-0x000000018148D5B0
	}
}
