/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	public struct TMP_MeshInfo // TypeDefIndex: 8989
	{
		// Fields
		private static readonly Color32 s_DefaultColor; // 0x00
		private static readonly Vector3 s_DefaultNormal; // 0x04
		private static readonly Vector4 s_DefaultTangent; // 0x10
		private static readonly Bounds s_DefaultBounds; // 0x20
		public Mesh mesh; // 0x00
		public int vertexCount; // 0x08
		public Vector3[] vertices; // 0x10
		public Vector3[] normals; // 0x18
		public Vector4[] tangents; // 0x20
		public Vector2[] uvs0; // 0x28
		public Vector2[] uvs2; // 0x30
		public Color32[] colors32; // 0x38
		public int[] triangles; // 0x40
	
		// Constructors
		public TMP_MeshInfo(Mesh mesh, int size); // 0x00000001800096C0-0x00000001800096D0
		public TMP_MeshInfo(Mesh mesh, int size, bool isVolumetric); // 0x00000001800096D0-0x00000001800097F0
		static TMP_MeshInfo(); // 0x00000001805A95B0-0x00000001805AAA60
	
		// Methods
		public void ResizeMeshInfo(int size); // 0x00000001800094B0-0x00000001800094C0
		public void ResizeMeshInfo(int size, bool isVolumetric); // 0x00000001800094C0-0x00000001800094D0
		public void Clear(); // 0x0000000180009400-0x00000001800094B0
		public void Clear(bool uploadChanges); // 0x00000001800092B0-0x0000000180009400
		public void ClearUnusedVertices(); // 0x0000000180009270-0x00000001800092B0
		public void ClearUnusedVertices(int startIndex); // 0x0000000180009180-0x00000001800091B0
		public void ClearUnusedVertices(int startIndex, bool updateMesh); // 0x00000001800091B0-0x0000000180009270
		public void SortGeometry(VertexSortingOrder order); // 0x00000001800094D0-0x0000000180009550
		public void SortGeometry(IList<int> sortingOrder); // 0x0000000180009550-0x00000001800096B0
		public void SwapVertexData(int src, int dst); // 0x00000001800096B0-0x00000001800096C0
	}
}
