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
	[CreateAssetMenu] // 0x000000018028FAB0-0x000000018028FAF0
	public class PerlinShake : CharacterAnimator // TypeDefIndex: 16226
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _speedScale; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector2 _moveScale; // 0x24
	
		// Constructors
		public PerlinShake(); // 0x0000000180979F50-0x0000000180979FD0
	
		// Methods
		protected override void UpdateAnimationImplementation(TMP_TextInfo inTextInfo, TMP_CharacterInfo inCharInfo, Vector3[] inOriginalPositions, int inVisibleCharacterIndex, float inStrength); // 0x0000000180979A10-0x0000000180979F50
	}
}
