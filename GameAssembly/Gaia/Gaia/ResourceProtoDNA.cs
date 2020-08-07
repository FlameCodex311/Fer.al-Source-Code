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
	[Serializable]
	public class ResourceProtoDNA // TypeDefIndex: 9207
	{
		// Fields
		[Tooltip] // 0x00000001802319B0-0x00000001802319E0
		public float m_width; // 0x10
		[Tooltip] // 0x0000000180231AD0-0x0000000180231B00
		public float m_height; // 0x14
		[Tooltip] // 0x0000000180231C00-0x0000000180231C30
		public float m_boundsRadius; // 0x18
		[Tooltip] // 0x0000000180231D70-0x0000000180231DA0
		public float m_seedThrow; // 0x1C
		[Tooltip] // 0x0000000180231EE0-0x0000000180231F10
		public float m_minScale; // 0x20
		[Tooltip] // 0x0000000180232250-0x0000000180232280
		public float m_maxScale; // 0x24
		[Tooltip] // 0x00000001802322B0-0x00000001802322E0
		public bool m_rndScaleInfluence; // 0x28
		[Tooltip] // 0x00000001802323B0-0x00000001802323E0
		public string m_extParam; // 0x30
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public int m_protoIdx; // 0x38
	
		// Constructors
		public ResourceProtoDNA(); // 0x00000001819A3940-0x00000001819A39B0
	
		// Methods
		public void Update(int protoIdx); // 0x000000018041B190-0x000000018041B1A0
		public void Update(int protoIdx, float width, float height); // 0x00000001819A38A0-0x00000001819A3940
		public void Update(int protoIdx, float width, float height, float minscale, float maxscale); // 0x00000001819A37F0-0x00000001819A38A0
		public float GetScale(float fitness); // 0x00000001819A37D0-0x00000001819A37F0
		public float GetScale(float fitness, float random); // 0x00000001819A37B0-0x00000001819A37D0
	}
}
