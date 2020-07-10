/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace FancyScrollView
{
	public class Example04Scene : MonoBehaviour // TypeDefIndex: 15870
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Example04ScrollView scrollView; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Button prevCellButton; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Button nextCellButton; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private UnityEngine.UI.Text selectedItemInfo; // 0x38
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 15871
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<int, Example04CellDto> <>9__4_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001814AB270-0x00000001814AB2D0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal Example04CellDto <Start>b__4_0(int i); // 0x00000001814AB180-0x00000001814AB210
		}
	
		// Constructors
		public Example04Scene(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		private void Start(); // 0x000000018148D700-0x000000018148D9B0
		private void HandleSelectedIndexChanged(int index); // 0x000000018148D670-0x000000018148D700
	}
}
