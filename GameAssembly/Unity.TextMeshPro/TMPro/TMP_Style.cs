/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	[Serializable]
	public class TMP_Style // TypeDefIndex: 8847
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string m_Name; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int m_HashCode; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string m_OpeningDefinition; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string m_ClosingDefinition; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int[] m_OpeningTagArray; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int[] m_ClosingTagArray; // 0x38
	
		// Properties
		public string name { get; set; } // 0x000000018036AC80-0x000000018036AC90 0x00000001811A8CF0-0x00000001811A8D30
		public int hashCode { get; set; } // 0x0000000180367710-0x0000000180367720 0x00000001811A8CE0-0x00000001811A8CF0
		public string styleOpeningDefinition { get; } // 0x000000018036AC70-0x000000018036AC80 
		public string styleClosingDefinition { get; } // 0x0000000180369B60-0x0000000180369B70 
		public int[] styleOpeningTagArray { get; } // 0x0000000180397720-0x0000000180397730 
		public int[] styleClosingTagArray { get; } // 0x0000000180369BB0-0x0000000180369BC0 
	
		// Constructors
		public TMP_Style(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public void RefreshStyle(); // 0x00000001811A8B10-0x00000001811A8CE0
	}
}
