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
	[CreateAssetMenu] // 0x000000018016E880-0x000000018016E8C0
	public class ScaleAndSkew : CharacterAnimator // TypeDefIndex: 15848
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _duration; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private AnimationCurve _scaleXCurve; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private AnimationCurve _scaleYCurve; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private AnimationCurve _skewCurve; // 0x38
		private Matrix4x4 matrix; // 0x40
	
		// Constructors
		public ScaleAndSkew(); // 0x000000018112B010-0x000000018112B060
	
		// Methods
		protected override void UpdateAnimationImplementation(TMP_TextInfo inTextInfo, TMP_CharacterInfo inCharInfo, Vector3[] inOriginalPositions, int inVisibleCharacterIndex, float inStrength); // 0x000000018112A800-0x000000018112B010
	}
}
