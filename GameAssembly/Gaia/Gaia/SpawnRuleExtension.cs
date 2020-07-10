/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	public class SpawnRuleExtension : UnityEngine.MonoBehaviour // TypeDefIndex: 9073
	{
		// Constructors
		public SpawnRuleExtension(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		public virtual void Initialise(); // 0x00000001803581E0-0x00000001803581F0
		public virtual bool AffectsTextures(); // 0x00000001803C28F0-0x00000001803C2900
		public virtual bool AffectsDetails(); // 0x00000001803C28F0-0x00000001803C2900
		public virtual float GetFitness(float fitness, ref SpawnInfo spawnInfo); // 0x0000000180F47D30-0x0000000180F47D40
		public virtual bool OverridesSpawn(SpawnRule spawnRule, ref SpawnInfo spawnInfo); // 0x00000001803C28F0-0x00000001803C2900
		public virtual void Spawn(SpawnRule spawnRule, ref SpawnInfo spawnInfo); // 0x00000001803581E0-0x00000001803581F0
		public virtual void PostSpawn(SpawnRule spawnRule, ref SpawnInfo spawnInfo); // 0x00000001803581E0-0x00000001803581F0
	}
}
