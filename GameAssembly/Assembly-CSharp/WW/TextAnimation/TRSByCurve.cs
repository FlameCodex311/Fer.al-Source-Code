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
	[CreateAssetMenu] // 0x0000000180292010-0x0000000180292050
	public class TRSByCurve : CharacterAnimator // TypeDefIndex: 16230
	{
		// Fields
		[Header] // 0x0000000180292200-0x0000000180292250
		[SerializeField] // 0x0000000180292200-0x0000000180292250
		private AnimationCurve _moveXCurve; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private AnimationCurve _moveYCurve; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector2 _moveSpeed; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector2 _moveCurveScale; // 0x38
		[Header] // 0x0000000180292650-0x00000001802926A0
		[SerializeField] // 0x0000000180292650-0x00000001802926A0
		private AnimationCurve _rotateCurve; // 0x40
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _rotationSpeed; // 0x48
		[Header] // 0x00000001802928E0-0x0000000180292930
		[SerializeField] // 0x00000001802928E0-0x0000000180292930
		private AnimationCurve _scaleCurve; // 0x50
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _scaleSpeed; // 0x58
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _scaleCurveScale; // 0x5C
		[Header] // 0x0000000180293FB0-0x0000000180294000
		[SerializeField] // 0x0000000180293FB0-0x0000000180294000
		private float _curveOffsetPerCharacter; // 0x60
		private Matrix4x4 matrix; // 0x64
	
		// Constructors
		public TRSByCurve(); // 0x000000018097BC50-0x000000018097BD40
	
		// Methods
		protected override void UpdateAnimationImplementation(TMP_TextInfo inTextInfo, TMP_CharacterInfo inCharInfo, Vector3[] inOriginalPositions, int inVisibleCharacterIndex, float inStrength); // 0x000000018097B3C0-0x000000018097BC50
	}
}
