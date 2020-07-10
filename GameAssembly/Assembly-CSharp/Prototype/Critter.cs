/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype
{
	public class Critter : ManagedBehaviour // TypeDefIndex: 16067
	{
		// Fields
		private NavMeshAgent _agent; // 0x50
		private Animation _animation; // 0x58
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Transform _navParent; // 0x60
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private AnimationClip[] _clips; // 0x68
		private float _pathTimer; // 0x70
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _pathRandomMinTime; // 0x74
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _pathRandomMaxTime; // 0x78
		private float _animTimer; // 0x7C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _randomAnimMinTime; // 0x80
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _randomAnimMaxTime; // 0x84
		private static Critter _critter; // 0x00
	
		// Constructors
		public Critter(); // 0x000000018139E040-0x000000018139E0C0
	
		// Methods
		public static Critter Get(); // 0x000000018139DC20-0x000000018139DCC0
		public override void MStart(); // 0x000000018139DCC0-0x000000018139DD30
		public override void MUpdate(); // 0x000000018139DD30-0x000000018139DDB0
		private void SetNewAnim(); // 0x000000018139DDB0-0x000000018139DE70
		private void SetNewPath(); // 0x000000018139DE70-0x000000018139E040
	}
}
