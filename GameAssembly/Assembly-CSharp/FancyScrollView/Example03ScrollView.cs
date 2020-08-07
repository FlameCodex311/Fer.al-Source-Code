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
	public class Example03ScrollView : FancyScrollView<FancyScrollView.Example03CellDto, FancyScrollView.Example03ScrollViewContext> // TypeDefIndex: 14313
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ScrollPositionController scrollPositionController; // 0x60
	
		// Constructors
		public Example03ScrollView(); // 0x0000000180E20D60-0x0000000180E20DA0
	
		// Methods
		private void Awake(); // 0x0000000180E20B30-0x0000000180E20C10
		public void UpdateData(List<Example03CellDto> data); // 0x0000000180E20CF0-0x0000000180E20D60
		private void OnPressedCell(Example03ScrollViewCell cell); // 0x0000000180E20C10-0x0000000180E20CA0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <Awake>b__1_0(float p); // 0x0000000180E20CA0-0x0000000180E20CF0
	}
}
