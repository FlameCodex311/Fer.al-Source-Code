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
	public class Example02ScrollViewCell : FancyScrollViewCell<FancyScrollView.Example02CellDto, FancyScrollView.Example02ScrollViewContext> // TypeDefIndex: 15861
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Animator animator; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private UnityEngine.UI.Text message; // 0x38
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Image image; // 0x40
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Button button; // 0x48
		private static readonly int scrollTriggerHash; // 0x00
		private float currentPosition; // 0x50
	
		// Constructors
		public Example02ScrollViewCell(); // 0x000000018148CB90-0x000000018148CBD0
		static Example02ScrollViewCell(); // 0x000000018148CB40-0x000000018148CB90
	
		// Methods
		private void Start(); // 0x000000018148C8E0-0x000000018148C980
		public override void UpdateContent(Example02CellDto itemData); // 0x000000018148C980-0x000000018148CA80
		public override void UpdatePosition(float position); // 0x000000018148CA80-0x000000018148CB40
		private void OnPressedCell(); // 0x000000018148C880-0x000000018148C8E0
		private void OnEnable(); // 0x000000018148C860-0x000000018148C880
	}
}
