/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	public class SpawnRuleExtension : UnityEngine.MonoBehaviour // TypeDefIndex: 9232
	{
		// Constructors
		public SpawnRuleExtension(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		public virtual void Initialise(); // 0x00000001803774A0-0x00000001803774B0
		public virtual bool AffectsTextures(); // 0x0000000180380950-0x0000000180380960
		public virtual bool AffectsDetails(); // 0x0000000180380950-0x0000000180380960
		public virtual float GetFitness(float fitness, ref SpawnInfo spawnInfo); // 0x000000018055A6C0-0x000000018055A6D0
		public virtual bool OverridesSpawn(SpawnRule spawnRule, ref SpawnInfo spawnInfo); // 0x0000000180380950-0x0000000180380960
		public virtual void Spawn(SpawnRule spawnRule, ref SpawnInfo spawnInfo); // 0x00000001803774A0-0x00000001803774B0
		public virtual void PostSpawn(SpawnRule spawnRule, ref SpawnInfo spawnInfo); // 0x00000001803774A0-0x00000001803774B0
	}
}
