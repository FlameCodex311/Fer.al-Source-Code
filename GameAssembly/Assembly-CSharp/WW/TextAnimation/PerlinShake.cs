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
	[CreateAssetMenu] // 0x000000018016DF10-0x000000018016DF50
	public class PerlinShake : CharacterAnimator // TypeDefIndex: 15846
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _speedScale; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector2 _moveScale; // 0x24
	
		// Constructors
		public PerlinShake(); // 0x000000018112A0B0-0x000000018112A130
	
		// Methods
		protected override void UpdateAnimationImplementation(TMP_TextInfo inTextInfo, TMP_CharacterInfo inCharInfo, Vector3[] inOriginalPositions, int inVisibleCharacterIndex, float inStrength); // 0x0000000181129B50-0x000000018112A0B0
	}
}
