/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	[Serializable]
	public class TMP_Style // TypeDefIndex: 9009
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string m_Name; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int m_HashCode; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string m_OpeningDefinition; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string m_ClosingDefinition; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int[] m_OpeningTagArray; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int[] m_ClosingTagArray; // 0x38
	
		// Properties
		public string name { get; set; } // 0x0000000180372440-0x0000000180372450 0x00000001805ADF40-0x00000001805ADF80
		public int hashCode { get; set; } // 0x00000001803F46B0-0x00000001803F46C0 0x00000001805ADF30-0x00000001805ADF40
		public string styleOpeningDefinition { get; } // 0x0000000180374AF0-0x0000000180374B00 
		public string styleClosingDefinition { get; } // 0x00000001803745B0-0x00000001803745C0 
		public int[] styleOpeningTagArray { get; } // 0x00000001803745C0-0x00000001803745D0 
		public int[] styleClosingTagArray { get; } // 0x00000001803743D0-0x00000001803743E0 
	
		// Constructors
		public TMP_Style(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public void RefreshStyle(); // 0x00000001805ADD70-0x00000001805ADF30
	}
}
