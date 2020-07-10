/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Avatar_Network : AvatarBase // TypeDefIndex: 10079
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 10080
	{
		// Fields
		public ActorInfoMessageData data; // 0x10
		public Avatar_Network <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OnObjectInfo>b__0(GameObject inGameObject, ActorInfo inInfo); // 0x000000018104D760-0x000000018104D880
	}

	// Constructors
	public Avatar_Network(); // 0x000000018103EC20-0x000000018103EC80

	// Methods
	public static Avatar_Network CreateNetwork(string inWorldObjectDefID, ActorInfo inInfo, Vector3 inPosition, Quaternion inRotation, Action<GameObject, ActorInfo> inFinishedCallback); // 0x0000000181040020-0x00000001810400F0
	public override void OnObjectInfo(WorldObjectInfoMessage inInfoMessage); // 0x00000001810400F0-0x00000001810402D0
}

