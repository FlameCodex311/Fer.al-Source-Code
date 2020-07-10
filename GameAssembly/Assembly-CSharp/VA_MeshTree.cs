/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class VA_MeshTree // TypeDefIndex: 13244
{
	// Fields
	public List<Node> Nodes; // 0x10
	public List<Triangle> Triangles; // 0x18
	private static List<Triangle> closestTriangles; // 0x00
	private static float closestSqrDistance; // 0x08

	// Nested types
	[Serializable]
	public class Node // TypeDefIndex: 13245
	{
		// Fields
		public Bounds Bound; // 0x10
		public int PositiveIndex; // 0x28
		public int NegativeIndex; // 0x2C
		public int TriangleIndex; // 0x30
		public int TriangleCount; // 0x34

		// Constructors
		public Node(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class Triangle // TypeDefIndex: 13246
	{
		// Fields
		public Vector3 A; // 0x10
		public Vector3 B; // 0x1C
		public Vector3 C; // 0x28

		// Properties
		public Vector3 Min { get; } // 0x000000018112C190-0x000000018112C2A0 
		public Vector3 Max { get; } // 0x000000018112C020-0x000000018112C130 
		public float MidX { get; } // 0x000000018112C130-0x000000018112C150 
		public float MidY { get; } // 0x000000018112C150-0x000000018112C170 
		public float MidZ { get; } // 0x000000018112C170-0x000000018112C190 

		// Constructors
		public Triangle(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	// Constructors
	public VA_MeshTree(); // 0x000000018112FE10-0x000000018112FE90
	static VA_MeshTree(); // 0x000000018112FDB0-0x000000018112FE10

	// Methods
	public void Clear(); // 0x000000018112E630-0x000000018112E690
	public void Bake(Mesh mesh); // 0x000000018112DBD0-0x000000018112DCF0
	public Vector3 FindClosestPoint(Vector3 point); // 0x000000018112EC60-0x000000018112F080
	private void Search(Node node, Vector3 point); // 0x000000018112FAE0-0x000000018112FDB0
	private float NearSqrDistance(Node node, Vector3 point); // 0x000000018112F300-0x000000018112F340
	private float FarSqrDistance(Node node, Vector3 point); // 0x000000018112E690-0x000000018112EC60
	private void AddToResults(Node node); // 0x000000018112DAF0-0x000000018112DBD0
	private List<Triangle> GetAllTriangles(Mesh mesh); // 0x000000018112F080-0x000000018112F300
	private void Pack(Node node, List<Triangle> tris); // 0x000000018112F340-0x000000018112FAE0
	private void CalculateBound(Node node, List<Triangle> tris); // 0x000000018112E2F0-0x000000018112E630
	private void CalculateAxisAndPivot(List<Triangle> tris, ref int axis, ref float pivot); // 0x000000018112DCF0-0x000000018112E2F0
}

