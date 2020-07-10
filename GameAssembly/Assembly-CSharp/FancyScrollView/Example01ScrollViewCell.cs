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
	public class Example01ScrollViewCell : FancyScrollViewCell<FancyScrollView.Example01CellDto> // TypeDefIndex: 15856
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Animator animator; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private UnityEngine.UI.Text message; // 0x38
		private static readonly int scrollTriggerHash; // 0x00
		private float currentPosition; // 0x40
	
		// Constructors
		public Example01ScrollViewCell(); // 0x000000018148C500-0x000000018148C540
		static Example01ScrollViewCell(); // 0x000000018148C4B0-0x000000018148C500
	
		// Methods
		public override void UpdateContent(Example01CellDto itemData); // 0x000000018148C3B0-0x000000018148C3F0
		public override void UpdatePosition(float position); // 0x000000018148C3F0-0x000000018148C4B0
		private void OnEnable(); // 0x000000018148C390-0x000000018148C3B0
	}
}
