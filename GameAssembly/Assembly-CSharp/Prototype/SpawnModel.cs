/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype
{
	public class SpawnModel : ManagedBehaviour // TypeDefIndex: 14825
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private GameObject _modelPrefab; // 0x50
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private RuntimeAnimatorController _animatorController; // 0x58
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _scale; // 0x60
		private Animator _animator; // 0x68
	
		// Constructors
		public SpawnModel(); // 0x0000000180A3D5C0-0x0000000180A3D620
	
		// Methods
		public override void MStart(); // 0x0000000180A3D0E0-0x0000000180A3D3D0
		private void OnDrawGizmos(); // 0x0000000180A3D3D0-0x0000000180A3D5C0
	}
}
