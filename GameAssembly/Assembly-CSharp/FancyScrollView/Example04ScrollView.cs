/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace FancyScrollView
{
	public class Example04ScrollView : FancyScrollView<FancyScrollView.Example04CellDto, FancyScrollView.Example04ScrollViewContext> // TypeDefIndex: 14319
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ScrollPositionController scrollPositionController; // 0x60
		private Action<int> onSelectedIndexChanged; // 0x68
	
		// Constructors
		public Example04ScrollView(); // 0x0000000180E21B90-0x0000000180E21BD0
	
		// Methods
		private void Awake(); // 0x0000000180E21670-0x0000000180E217C0
		public void UpdateData(List<Example04CellDto> data); // 0x0000000180E219F0-0x0000000180E21A60
		public void UpdateSelection(int index); // 0x0000000180E21A60-0x0000000180E21B90
		public void OnSelectedIndexChanged(Action<int> onSelectedIndexChanged); // 0x00000001804ADAC0-0x00000001804ADAD0
		public void SelectNextCell(); // 0x0000000180E218B0-0x0000000180E21900
		public void SelectPrevCell(); // 0x0000000180E21900-0x0000000180E21950
		private void HandleItemSelected(int selectedItemIndex); // 0x0000000180E217C0-0x0000000180E21860
		private void OnPressedCell(Example04ScrollViewCell cell); // 0x0000000180E21860-0x0000000180E218B0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <Awake>b__2_0(float p); // 0x0000000180E21950-0x0000000180E219A0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <Awake>b__2_1(int index); // 0x0000000180E219A0-0x0000000180E219F0
	}
}
