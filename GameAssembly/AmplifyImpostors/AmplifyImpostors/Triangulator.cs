/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 73: AmplifyImpostors.dll - Assembly: AmplifyImpostors, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8910-8940

namespace AmplifyImpostors
{
	public class Triangulator // TypeDefIndex: 8937
	{
		// Fields
		private List<Vector2> m_points; // 0x10
	
		// Properties
		public List<Vector2> Points { get; } // 0x000000018036AC80-0x000000018036AC90 
	
		// Constructors
		public Triangulator(Vector2[] points); // 0x00000001822B3B50-0x00000001822B3BF0
		public Triangulator(Vector2[] points, bool invertY = true /* Metadata: 0x00743E13 */); // 0x00000001822B3BF0-0x00000001822B3D50
	
		// Methods
		public int[] Triangulate(); // 0x00000001822B3660-0x00000001822B3B50
		private float Area(); // 0x00000001822B3130-0x00000001822B3290
		private bool Snip(int u, int v, int w, int n, int[] V); // 0x00000001822B3370-0x00000001822B3660
		private bool InsideTriangle(Vector2 pt, Vector2 v1, Vector2 v2, Vector2 v3); // 0x00000001822B3290-0x00000001822B3370
	}
}
