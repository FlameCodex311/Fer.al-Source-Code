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
	public class Example02ScrollView : FancyScrollView<FancyScrollView.Example02CellDto, FancyScrollView.Example02ScrollViewContext> // TypeDefIndex: 14307
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ScrollPositionController scrollPositionController; // 0x60
	
		// Constructors
		public Example02ScrollView(); // 0x0000000180E20560-0x0000000180E205A0
	
		// Methods
		private void Awake(); // 0x0000000180E20330-0x0000000180E20410
		public void UpdateData(List<Example02CellDto> data); // 0x0000000180E204F0-0x0000000180E20560
		private void OnPressedCell(Example02ScrollViewCell cell); // 0x0000000180E20410-0x0000000180E204A0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <Awake>b__1_0(float p); // 0x0000000180E204A0-0x0000000180E204F0
	}
}
