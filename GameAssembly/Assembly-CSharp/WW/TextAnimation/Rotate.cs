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
	[CreateAssetMenu] // 0x000000018016E480-0x000000018016E4C0
	public class Rotate : CharacterAnimator // TypeDefIndex: 15847
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _speedScale; // 0x20
		private Matrix4x4 matrix; // 0x24
	
		// Constructors
		public Rotate(); // 0x000000018112A7B0-0x000000018112A800
	
		// Methods
		protected override void UpdateAnimationImplementation(TMP_TextInfo inTextInfo, TMP_CharacterInfo inCharInfo, Vector3[] inOriginalPositions, int inVisibleCharacterIndex, float inStrength); // 0x000000018112A130-0x000000018112A7B0
	}
}
