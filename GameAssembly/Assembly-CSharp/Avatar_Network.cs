/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Avatar_Network : AvatarBase // TypeDefIndex: 11570
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 11571
	{
		// Fields
		public ActorInfoMessageData data; // 0x10
		public Avatar_Network <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OnObjectInfo>b__0(GameObject inGameObject, ActorInfo inInfo); // 0x00000001821603E0-0x0000000182160500
	}

	// Constructors
	public Avatar_Network(); // 0x0000000182157C60-0x0000000182157CC0

	// Methods
	public static Avatar_Network CreateNetwork(string inWorldObjectDefID, ActorInfo inInfo, Vector3 inPosition, Quaternion inRotation, Action<GameObject, ActorInfo> inFinishedCallback); // 0x0000000182159D00-0x0000000182159DD0
	public override void OnObjectInfo(WorldObjectInfoMessage inInfoMessage); // 0x0000000182159DD0-0x0000000182159FA0
}

