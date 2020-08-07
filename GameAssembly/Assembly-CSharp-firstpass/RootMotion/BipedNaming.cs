/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion
{
	public static class BipedNaming // TypeDefIndex: 9762
	{
		// Fields
		public static string[] typeLeft; // 0x00
		public static string[] typeRight; // 0x08
		public static string[] typeSpine; // 0x10
		public static string[] typeHead; // 0x18
		public static string[] typeArm; // 0x20
		public static string[] typeLeg; // 0x28
		public static string[] typeTail; // 0x30
		public static string[] typeEye; // 0x38
		public static string[] typeExclude; // 0x40
		public static string[] typeExcludeSpine; // 0x48
		public static string[] typeExcludeHead; // 0x50
		public static string[] typeExcludeArm; // 0x58
		public static string[] typeExcludeLeg; // 0x60
		public static string[] typeExcludeTail; // 0x68
		public static string[] typeExcludeEye; // 0x70
		public static string[] pelvis; // 0x78
		public static string[] hand; // 0x80
		public static string[] foot; // 0x88
	
		// Nested types
		[Serializable]
		public enum BoneType // TypeDefIndex: 9763
		{
			Unassigned = 0,
			Spine = 1,
			Head = 2,
			Arm = 3,
			Leg = 4,
			Tail = 5,
			Eye = 6
		}
	
		[Serializable]
		public enum BoneSide // TypeDefIndex: 9764
		{
			Center = 0,
			Left = 1,
			Right = 2
		}
	
		// Constructors
		static BipedNaming(); // 0x0000000180D1B6B0-0x0000000180D1E520
	
		// Methods
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones); // 0x0000000180D1B1B0-0x0000000180D1B360
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones); // 0x0000000180D1AF80-0x0000000180D1B130
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones); // 0x0000000180D1B130-0x0000000180D1B1B0
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones); // 0x0000000180D1B360-0x0000000180D1B410
		public static Transform GetNamingMatch(Transform[] transforms, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ string[][] namings); // 0x0000000180D1B410-0x0000000180D1B670
		public static BoneType GetBoneType(string boneName); // 0x0000000180D1AD70-0x0000000180D1AEF0
		public static BoneSide GetBoneSide(string boneName); // 0x0000000180D1ACE0-0x0000000180D1AD70
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center /* Metadata: 0x0077AAAE */, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ string[][] namings); // 0x0000000180D1AEF0-0x0000000180D1AF80
		private static bool isLeft(string boneName); // 0x0000000180D1ECA0-0x0000000180D1EF20
		private static bool isRight(string boneName); // 0x0000000180D1F150-0x0000000180D1F3D0
		private static bool isSpine(string boneName); // 0x0000000180D1F3D0-0x0000000180D1F600
		private static bool isHead(string boneName); // 0x0000000180D1EA70-0x0000000180D1ECA0
		private static bool isArm(string boneName); // 0x0000000180D1E610-0x0000000180D1E840
		private static bool isLeg(string boneName); // 0x0000000180D1EF20-0x0000000180D1F150
		private static bool isTail(string boneName); // 0x0000000180D1F600-0x0000000180D1F830
		private static bool isEye(string boneName); // 0x0000000180D1E840-0x0000000180D1EA70
		private static bool isTypeExclude(string boneName); // 0x0000000180D1F830-0x0000000180D1F9C0
		private static bool matchesNaming(string boneName, string[] namingConvention); // 0x0000000180D1FB00-0x0000000180D1FC40
		private static bool excludesNaming(string boneName, string[] namingConvention); // 0x0000000180D1E520-0x0000000180D1E5B0
		private static bool matchesLastLetter(string boneName, string[] namingConvention); // 0x0000000180D1FA20-0x0000000180D1FB00
		private static bool LastLetterIs(string boneName, string letter); // 0x0000000180D1B670-0x0000000180D1B6B0
		private static string firstLetter(string boneName); // 0x0000000180D1E5B0-0x0000000180D1E610
		private static string lastLetter(string boneName); // 0x0000000180D1F9C0-0x0000000180D1FA20
	}
}
