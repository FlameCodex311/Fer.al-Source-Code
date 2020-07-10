﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Electric : MonoBehaviour // TypeDefIndex: 12780
{
	// Fields
	private LineRenderer lRend; // 0x20
	public Transform transformPointA; // 0x28
	public Transform transformPointB; // 0x30
	public float UVVariation; // 0x38
	private readonly int pointsCount; // 0x3C
	private readonly int half; // 0x40
	private float randomness; // 0x44
	private Vector3[] points; // 0x48
	private readonly int pointIndexA; // 0x50
	private readonly int pointIndexB; // 0x54
	private readonly int pointIndexC; // 0x58
	private readonly int pointIndexD; // 0x5C
	private readonly int pointIndexE; // 0x60
	private readonly string mainTexture; // 0x68
	private Vector2 mainTextureScale; // 0x70
	private Vector2 mainTextureOffset; // 0x78
	private float timer; // 0x80
	private float timerTimeOut; // 0x84

	// Constructors
	public Electric(); // 0x0000000181190920-0x0000000181190A00

	// Methods
	private void Start(); // 0x00000001811908A0-0x0000000181190910
	private void Update(); // 0x0000000181190910-0x0000000181190920
	private void CalculatePoints(); // 0x000000018118FEC0-0x0000000181190600
	private void SetRandomness(); // 0x00000001811906F0-0x00000001811908A0
	private Vector3 GetCenter(Vector3 a, Vector3 b); // 0x0000000181190600-0x00000001811906F0
}

