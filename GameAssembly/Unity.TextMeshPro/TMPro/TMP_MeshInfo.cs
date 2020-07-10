/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	public struct TMP_MeshInfo // TypeDefIndex: 8827
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
		public TMP_MeshInfo(Mesh mesh, int size); // 0x000000018020E390-0x000000018020E3A0
		public TMP_MeshInfo(Mesh mesh, int size, bool isVolumetric); // 0x000000018020E3A0-0x000000018020E520
		static TMP_MeshInfo(); // 0x00000001811A40C0-0x00000001811A5630
	
		// Methods
		public void ResizeMeshInfo(int size); // 0x000000018020E180-0x000000018020E190
		public void ResizeMeshInfo(int size, bool isVolumetric); // 0x000000018020E190-0x000000018020E1A0
		public void Clear(); // 0x000000018020E0D0-0x000000018020E180
		public void Clear(bool uploadChanges); // 0x000000018020DF80-0x000000018020E0D0
		public void ClearUnusedVertices(); // 0x000000018020DF40-0x000000018020DF80
		public void ClearUnusedVertices(int startIndex); // 0x000000018020DE50-0x000000018020DE80
		public void ClearUnusedVertices(int startIndex, bool updateMesh); // 0x000000018020DE80-0x000000018020DF40
		public void SortGeometry(VertexSortingOrder order); // 0x000000018020E1A0-0x000000018020E220
		public void SortGeometry(IList<int> sortingOrder); // 0x000000018020E220-0x000000018020E380
		public void SwapVertexData(int src, int dst); // 0x000000018020E380-0x000000018020E390
	}
}
