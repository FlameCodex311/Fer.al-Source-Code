/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype
{
	public class Critter : ManagedBehaviour // TypeDefIndex: 14806
	{
		// Fields
		private NavMeshAgent _agent; // 0x50
		private Animation _animation; // 0x58
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Transform _navParent; // 0x60
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private AnimationClip[] _clips; // 0x68
		private float _pathTimer; // 0x70
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _pathRandomMinTime; // 0x74
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _pathRandomMaxTime; // 0x78
		private float _animTimer; // 0x7C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _randomAnimMinTime; // 0x80
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _randomAnimMaxTime; // 0x84
		private static Critter _critter; // 0x00
	
		// Constructors
		public Critter(); // 0x0000000180AD4560-0x0000000180AD45E0
	
		// Methods
		public static Critter Get(); // 0x0000000180AD4140-0x0000000180AD41E0
		public override void MStart(); // 0x0000000180AD41E0-0x0000000180AD4250
		public override void MUpdate(); // 0x0000000180AD4250-0x0000000180AD42D0
		private void SetNewAnim(); // 0x0000000180AD42D0-0x0000000180AD4390
		private void SetNewPath(); // 0x0000000180AD4390-0x0000000180AD4560
	}
}
