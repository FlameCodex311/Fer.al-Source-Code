/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace FancyScrollView
{
	public class FancyScrollViewCell_Temp : FancyScrollViewCell<int, FancyScrollView.FancyScrollViewContext_Temp> // TypeDefIndex: 15885
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private WWTextMeshProUGUI _text; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private FeralButton _button; // 0x38
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private AnimationCurve _scaleAnimCurve; // 0x40
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private AnimationCurve _posAnimCurve; // 0x48
		private int _itemData; // 0x50
		private float currentPosition; // 0x54
	
		// Properties
		public override bool IsSelectable { get; } // 0x0000000181492460-0x0000000181492470 
	
		// Constructors
		public FancyScrollViewCell_Temp(); // 0x0000000181492420-0x0000000181492460
	
		// Methods
		private void Start(); // 0x0000000181492080-0x0000000181492120
		public override void UpdateContent(int itemData); // 0x0000000181492120-0x0000000181492230
		public override void UpdatePosition(float position); // 0x0000000181492230-0x0000000181492420
		private void OnPressedCell(); // 0x0000000181492020-0x0000000181492080
		private void OnEnable(); // 0x0000000181492000-0x0000000181492020
	}
}
