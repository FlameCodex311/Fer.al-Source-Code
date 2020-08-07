/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace FancyScrollView
{
	public class FancyScrollViewCell_Temp : FancyScrollViewCell<int, FancyScrollView.FancyScrollViewContext_Temp> // TypeDefIndex: 14332
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private WWTextMeshProUGUI _text; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private FeralButton _button; // 0x38
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private AnimationCurve _scaleAnimCurve; // 0x40
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private AnimationCurve _posAnimCurve; // 0x48
		private int _itemData; // 0x50
		private float currentPosition; // 0x54
	
		// Properties
		public override bool IsSelectable { get; } // 0x0000000180E22020-0x0000000180E22030 
	
		// Constructors
		public FancyScrollViewCell_Temp(); // 0x0000000180E21FE0-0x0000000180E22020
	
		// Methods
		private void Start(); // 0x0000000180E21C50-0x0000000180E21CE0
		public override void UpdateContent(int itemData); // 0x0000000180E21CE0-0x0000000180E21DF0
		public override void UpdatePosition(float position); // 0x0000000180E21DF0-0x0000000180E21FE0
		private void OnPressedCell(); // 0x0000000180E21BF0-0x0000000180E21C50
		private void OnEnable(); // 0x0000000180E21BD0-0x0000000180E21BF0
	}
}
