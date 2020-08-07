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
	public class Example01ScrollViewCell : FancyScrollViewCell<FancyScrollView.Example01CellDto> // TypeDefIndex: 14303
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Animator animator; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private UnityEngine.UI.Text message; // 0x38
		private static readonly int scrollTriggerHash; // 0x00
		private float currentPosition; // 0x40
	
		// Constructors
		public Example01ScrollViewCell(); // 0x0000000180860E70-0x0000000180860EB0
		static Example01ScrollViewCell(); // 0x0000000180860E20-0x0000000180860E70
	
		// Methods
		public override void UpdateContent(Example01CellDto itemData); // 0x0000000180860D20-0x0000000180860D60
		public override void UpdatePosition(float position); // 0x0000000180860D60-0x0000000180860E20
		private void OnEnable(); // 0x0000000180860D00-0x0000000180860D20
	}
}
