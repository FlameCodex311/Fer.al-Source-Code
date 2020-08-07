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
	public class Example03ScrollViewCell : FancyScrollViewCell<FancyScrollView.Example03CellDto, FancyScrollView.Example03ScrollViewContext> // TypeDefIndex: 14314
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
		public Example03ScrollViewCell(); // 0x0000000180E20AF0-0x0000000180E20B30
		static Example03ScrollViewCell(); // 0x0000000180E20AA0-0x0000000180E20AF0
	
		// Methods
		private void Start(); // 0x0000000180E20780-0x0000000180E208E0
		public override void UpdateContent(Example03CellDto itemData); // 0x0000000180E208E0-0x0000000180E209E0
		public override void UpdatePosition(float position); // 0x0000000180E209E0-0x0000000180E20AA0
		private void OnPressedCell(); // 0x0000000180E20720-0x0000000180E20780
		private void OnEnable(); // 0x0000000180E1FFD0-0x0000000180E1FFF0
	}
}
