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
	[Serializable]
	public class ResourceProtoDNA // TypeDefIndex: 9043
	{
		// Fields
		[Tooltip] // 0x00000001800D4E20-0x00000001800D4E50
		public float m_width; // 0x10
		[Tooltip] // 0x00000001800D4FD0-0x00000001800D5000
		public float m_height; // 0x14
		[Tooltip] // 0x00000001800D51C0-0x00000001800D51F0
		public float m_boundsRadius; // 0x18
		[Tooltip] // 0x00000001800D5390-0x00000001800D53C0
		public float m_seedThrow; // 0x1C
		[Tooltip] // 0x00000001800D55C0-0x00000001800D55F0
		public float m_minScale; // 0x20
		[Tooltip] // 0x00000001800D5750-0x00000001800D5780
		public float m_maxScale; // 0x24
		[Tooltip] // 0x00000001800D5900-0x00000001800D5930
		public bool m_rndScaleInfluence; // 0x28
		[Tooltip] // 0x00000001800D5A80-0x00000001800D5AB0
		public string m_extParam; // 0x30
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public int m_protoIdx; // 0x38
	
		// Constructors
		public ResourceProtoDNA(); // 0x000000018178EE40-0x000000018178EEB0
	
		// Methods
		public void Update(int protoIdx); // 0x000000018036C620-0x000000018036C630
		public void Update(int protoIdx, float width, float height); // 0x000000018178EDA0-0x000000018178EE40
		public void Update(int protoIdx, float width, float height, float minscale, float maxscale); // 0x000000018178ECF0-0x000000018178EDA0
		public float GetScale(float fitness); // 0x000000018178ECD0-0x000000018178ECF0
		public float GetScale(float fitness, float random); // 0x000000018178ECB0-0x000000018178ECD0
	}
}
