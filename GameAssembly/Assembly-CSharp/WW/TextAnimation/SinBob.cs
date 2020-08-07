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
	[CreateAssetMenu] // 0x0000000180290910-0x0000000180290950
	public class SinBob : CharacterAnimator // TypeDefIndex: 16229
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _speedScale; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _amplitude; // 0x24
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _frequency; // 0x28
	
		// Constructors
		public SinBob(); // 0x000000018097B360-0x000000018097B3C0
	
		// Methods
		protected override void UpdateAnimationImplementation(TMP_TextInfo inTextInfo, TMP_CharacterInfo inCharInfo, Vector3[] inOriginalPositions, int inVisibleCharacterIndex, float inStrength); // 0x000000018097AEC0-0x000000018097B360
	}
}
