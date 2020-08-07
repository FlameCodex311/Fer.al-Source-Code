/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

public static class FEasing // TypeDefIndex: 9682
{
	// Nested types
	public enum EFease // TypeDefIndex: 9683
	{
		EaseInCubic = 0,
		EaseOutCubic = 1,
		EaseInOutCubic = 2,
		EaseInOutElastic = 3,
		EaseInElastic = 4,
		EaseOutElastic = 5,
		EaseInExpo = 6,
		EaseOutExpo = 7,
		EaseInOutExpo = 8,
		Linear = 9
	}

	public delegate float Function(float s, float e, float v, float extraParameter = 1f /* Metadata: 0x0077A24B */); // TypeDefIndex: 9684; 0x0000000181089190-0x0000000181089520

	// Methods
	public static float EaseInCubic(float start, float end, float value, float ignore = 1f /* Metadata: 0x0077A1FB */); // 0x0000000181083CC0-0x0000000181083CE0
	public static float EaseOutCubic(float start, float end, float value, float ignore = 1f /* Metadata: 0x0077A1FF */); // 0x0000000181084200-0x0000000181084230
	public static float EaseInOutCubic(float start, float end, float value, float ignore = 1f /* Metadata: 0x0077A203 */); // 0x0000000181083EC0-0x0000000181083F20
	public static float EaseOutElastic(float start, float end, float value, float rangeMul = 1f /* Metadata: 0x0077A207 */); // 0x0000000181084230-0x0000000181084370
	public static float EaseInElastic(float start, float end, float value, float rangeMul = 1f /* Metadata: 0x0077A20B */); // 0x0000000181083CE0-0x0000000181083E20
	public static float EaseInOutElastic(float start, float end, float value, float rangeMul = 1f /* Metadata: 0x0077A20F */); // 0x0000000181083F20-0x00000001810840F0
	public static float EaseInExpo(float start, float end, float value, float ignore = 1f /* Metadata: 0x0077A213 */); // 0x0000000181083E20-0x0000000181083EC0
	public static float EaseOutExpo(float start, float end, float value, float ignore = 1f /* Metadata: 0x0077A217 */); // 0x0000000181084370-0x0000000181084420
	public static float EaseInOutExpo(float start, float end, float value, float ignore = 1f /* Metadata: 0x0077A21B */); // 0x00000001810840F0-0x0000000181084200
	public static float Linear(float start, float end, float value, float ignore = 1f /* Metadata: 0x0077A21F */); // 0x0000000181084590-0x0000000181084610
	public static Function GetEasingFunction(EFease easingFunction); // 0x0000000181084420-0x0000000181084590
}

