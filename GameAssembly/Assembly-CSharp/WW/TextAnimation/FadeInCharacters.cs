/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.TextAnimation
{
	[CreateAssetMenu] // 0x000000018028F710-0x000000018028F750
	public class FadeInCharacters : CharacterAnimator // TypeDefIndex: 16224
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3 _startOffset; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private AnimationCurve _fadeCurve; // 0x30
		private UI_Window_Dialog _dialogWindow; // 0x38
	
		// Properties
		private float VisibleCharacters { get; } // 0x000000018096F140-0x000000018096F200 
	
		// Constructors
		public FadeInCharacters(); // 0x00000001809679C0-0x0000000180967A00
	
		// Methods
		protected override void UpdateAnimationImplementation(TMP_TextInfo inTextInfo, TMP_CharacterInfo inCharInfo, Vector3[] inOriginalPositions, int inVisibleCharacterIndex, float inStrength); // 0x000000018096EC00-0x000000018096F140
	}
}
