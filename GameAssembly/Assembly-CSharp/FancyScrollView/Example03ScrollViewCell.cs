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
	public class Example03ScrollViewCell : FancyScrollViewCell<FancyScrollView.Example03CellDto, FancyScrollView.Example03ScrollViewContext> // TypeDefIndex: 15867
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
		public Example03ScrollViewCell(); // 0x000000018148D3B0-0x000000018148D3F0
		static Example03ScrollViewCell(); // 0x000000018148D360-0x000000018148D3B0
	
		// Methods
		private void Start(); // 0x000000018148D040-0x000000018148D1A0
		public override void UpdateContent(Example03CellDto itemData); // 0x000000018148D1A0-0x000000018148D2A0
		public override void UpdatePosition(float position); // 0x000000018148D2A0-0x000000018148D360
		private void OnPressedCell(); // 0x000000018148CFE0-0x000000018148D040
		private void OnEnable(); // 0x000000018148C860-0x000000018148C880
	}
}
