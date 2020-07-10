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
	public class Example04ScrollView : FancyScrollView<FancyScrollView.Example04CellDto, FancyScrollView.Example04ScrollViewContext> // TypeDefIndex: 15872
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ScrollPositionController scrollPositionController; // 0x60
		private Action<int> onSelectedIndexChanged; // 0x68
	
		// Constructors
		public Example04ScrollView(); // 0x000000018148E4A0-0x000000018148E4E0
	
		// Methods
		private void Awake(); // 0x000000018148DF70-0x000000018148E0C0
		public void UpdateData(List<Example04CellDto> data); // 0x000000018148E2F0-0x000000018148E370
		public void UpdateSelection(int index); // 0x000000018148E370-0x000000018148E4A0
		public void OnSelectedIndexChanged(Action<int> onSelectedIndexChanged); // 0x00000001803A27D0-0x00000001803A27E0
		public void SelectNextCell(); // 0x000000018148E1B0-0x000000018148E200
		public void SelectPrevCell(); // 0x000000018148E200-0x000000018148E250
		private void HandleItemSelected(int selectedItemIndex); // 0x000000018148E0C0-0x000000018148E160
		private void OnPressedCell(Example04ScrollViewCell cell); // 0x000000018148E160-0x000000018148E1B0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <Awake>b__2_0(float p); // 0x000000018148E250-0x000000018148E2A0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <Awake>b__2_1(int index); // 0x000000018148E2A0-0x000000018148E2F0
	}
}
