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
	[CreateAssetMenu] // 0x000000018016F0C0-0x000000018016F100
	public class SinBob : CharacterAnimator // TypeDefIndex: 15849
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _speedScale; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _amplitude; // 0x24
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _frequency; // 0x28
	
		// Constructors
		public SinBob(); // 0x000000018112B510-0x000000018112B570
	
		// Methods
		protected override void UpdateAnimationImplementation(TMP_TextInfo inTextInfo, TMP_CharacterInfo inCharInfo, Vector3[] inOriginalPositions, int inVisibleCharacterIndex, float inStrength); // 0x000000018112B060-0x000000018112B510
	}
}
