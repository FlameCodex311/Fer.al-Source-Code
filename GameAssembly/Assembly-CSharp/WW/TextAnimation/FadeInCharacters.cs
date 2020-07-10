/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.TextAnimation
{
	[CreateAssetMenu] // 0x000000018016C730-0x000000018016C770
	public class FadeInCharacters : CharacterAnimator // TypeDefIndex: 15844
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3 _startOffset; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private AnimationCurve _fadeCurve; // 0x30
		private UI_Window_Dialog _dialogWindow; // 0x38
	
		// Properties
		private float VisibleCharacters { get; } // 0x0000000181129990-0x0000000181129A50 
	
		// Constructors
		public FadeInCharacters(); // 0x0000000181119630-0x0000000181119670
	
		// Methods
		protected override void UpdateAnimationImplementation(TMP_TextInfo inTextInfo, TMP_CharacterInfo inCharInfo, Vector3[] inOriginalPositions, int inVisibleCharacterIndex, float inStrength); // 0x0000000181129430-0x0000000181129990
	}
}
