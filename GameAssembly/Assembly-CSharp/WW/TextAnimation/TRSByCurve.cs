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
	[CreateAssetMenu] // 0x000000018016FBD0-0x000000018016FC10
	public class TRSByCurve : CharacterAnimator // TypeDefIndex: 15850
	{
		// Fields
		[Header] // 0x000000018016FF10-0x000000018016FF60
		[SerializeField] // 0x000000018016FF10-0x000000018016FF60
		private AnimationCurve _moveXCurve; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private AnimationCurve _moveYCurve; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector2 _moveSpeed; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector2 _moveCurveScale; // 0x38
		[Header] // 0x0000000180170780-0x00000001801707D0
		[SerializeField] // 0x0000000180170780-0x00000001801707D0
		private AnimationCurve _rotateCurve; // 0x40
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _rotationSpeed; // 0x48
		[Header] // 0x0000000180170F50-0x0000000180170FA0
		[SerializeField] // 0x0000000180170F50-0x0000000180170FA0
		private AnimationCurve _scaleCurve; // 0x50
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _scaleSpeed; // 0x58
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _scaleCurveScale; // 0x5C
		[Header] // 0x0000000180171460-0x00000001801714B0
		[SerializeField] // 0x0000000180171460-0x00000001801714B0
		private float _curveOffsetPerCharacter; // 0x60
		private Matrix4x4 matrix; // 0x64
	
		// Constructors
		public TRSByCurve(); // 0x000000018112BE20-0x000000018112BF10
	
		// Methods
		protected override void UpdateAnimationImplementation(TMP_TextInfo inTextInfo, TMP_CharacterInfo inCharInfo, Vector3[] inOriginalPositions, int inVisibleCharacterIndex, float inStrength); // 0x000000018112B570-0x000000018112BE20
	}
}
