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
	[CreateAssetMenu] // 0x00000001802901C0-0x0000000180290200
	public class ScaleAndSkew : CharacterAnimator // TypeDefIndex: 16228
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _duration; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private AnimationCurve _scaleXCurve; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private AnimationCurve _scaleYCurve; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private AnimationCurve _skewCurve; // 0x38
		private Matrix4x4 matrix; // 0x40
	
		// Constructors
		public ScaleAndSkew(); // 0x000000018097AE70-0x000000018097AEC0
	
		// Methods
		protected override void UpdateAnimationImplementation(TMP_TextInfo inTextInfo, TMP_CharacterInfo inCharInfo, Vector3[] inOriginalPositions, int inVisibleCharacterIndex, float inStrength); // 0x000000018097A680-0x000000018097AE70
	}
}
