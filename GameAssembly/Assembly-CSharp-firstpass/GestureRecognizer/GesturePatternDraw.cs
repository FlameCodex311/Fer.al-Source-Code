/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace GestureRecognizer
{
	public class GesturePatternDraw : UILineRenderer // TypeDefIndex: 9585
	{
		// Fields
		public GesturePattern pattern; // 0x108
		public float endingSize; // 0x110
	
		// Constructors
		public GesturePatternDraw(); // 0x00000001816526B0-0x0000000181652750
	
		// Methods
		private void OnValidate(); // 0x0000000181652610-0x00000001816526B0
		protected override void OnPopulateMesh(VertexHelper vh); // 0x00000001816525E0-0x0000000181652610
		public void DrawPattern(); // 0x0000000181651FC0-0x00000001816525E0
	}
}
