/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class VA_MeshTree // TypeDefIndex: 10910
{
	// Fields
	public List<Node> Nodes; // 0x10
	public List<Triangle> Triangles; // 0x18
	private static List<Triangle> closestTriangles; // 0x00
	private static float closestSqrDistance; // 0x08

	// Nested types
	[Serializable]
	public class Node // TypeDefIndex: 10911
	{
		// Fields
		public Bounds Bound; // 0x10
		public int PositiveIndex; // 0x28
		public int NegativeIndex; // 0x2C
		public int TriangleIndex; // 0x30
		public int TriangleCount; // 0x34

		// Constructors
		public Node(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class Triangle // TypeDefIndex: 10912
	{
		// Fields
		public Vector3 A; // 0x10
		public Vector3 B; // 0x1C
		public Vector3 C; // 0x28

		// Properties
		public Vector3 Min { get; } // 0x0000000180668F70-0x0000000180669970 
		public Vector3 Max { get; } // 0x0000000180668E00-0x0000000180668F10 
		public float MidX { get; } // 0x0000000180668F10-0x0000000180668F30 
		public float MidY { get; } // 0x0000000180668F30-0x0000000180668F50 
		public float MidZ { get; } // 0x0000000180668F50-0x0000000180668F70 

		// Constructors
		public Triangle(); // 0x0000000180373240-0x0000000180373250
	}

	// Constructors
	public VA_MeshTree(); // 0x0000000180673FF0-0x0000000180674070
	static VA_MeshTree(); // 0x0000000180673F90-0x0000000180673FF0

	// Methods
	public void Clear(); // 0x0000000180672870-0x00000001806728D0
	public void Bake(Mesh mesh); // 0x0000000180671E30-0x0000000180671F50
	public Vector3 FindClosestPoint(Vector3 point); // 0x0000000180672EA0-0x00000001806732C0
	private void Search(Node node, Vector3 point); // 0x0000000180673CD0-0x0000000180673F90
	private float NearSqrDistance(Node node, Vector3 point); // 0x0000000180673520-0x0000000180673560
	private float FarSqrDistance(Node node, Vector3 point); // 0x00000001806728D0-0x0000000180672EA0
	private void AddToResults(Node node); // 0x0000000180671D50-0x0000000180671E30
	private List<Triangle> GetAllTriangles(Mesh mesh); // 0x00000001806732C0-0x0000000180673520
	private void Pack(Node node, List<Triangle> tris); // 0x0000000180673560-0x0000000180673CD0
	private void CalculateBound(Node node, List<Triangle> tris); // 0x0000000180672540-0x0000000180672870
	private void CalculateAxisAndPivot(List<Triangle> tris, ref int axis, ref float pivot); // 0x0000000180671F50-0x0000000180672540
}

