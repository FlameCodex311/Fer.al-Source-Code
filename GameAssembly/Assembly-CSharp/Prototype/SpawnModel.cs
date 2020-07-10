/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype
{
	public class SpawnModel : ManagedBehaviour // TypeDefIndex: 16086
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private GameObject _modelPrefab; // 0x50
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private RuntimeAnimatorController _animatorController; // 0x58
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _scale; // 0x60
		private Animator _animator; // 0x68
	
		// Constructors
		public SpawnModel(); // 0x0000000181600910-0x0000000181600970
	
		// Methods
		public override void MStart(); // 0x0000000181600410-0x0000000181600710
		private void OnDrawGizmos(); // 0x0000000181600710-0x0000000181600910
	}
}
