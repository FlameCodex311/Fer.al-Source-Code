/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

// Image 48: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5511-5701

namespace DG.Tweening
{
	public abstract class Tweener : Tween // TypeDefIndex: 5615
	{
		// Fields
		internal bool hasManuallySetStartValue; // 0x118
		internal bool isFromAllowed; // 0x119
	
		// Constructors
		internal Tweener(); // 0x0000000180DD21A0-0x0000000180DD21D0
	
		// Methods
		public abstract Tweener ChangeStartValue(object newStartValue, float newDuration = -1f /* Metadata: 0x0072E7CF */);
		public abstract Tweener ChangeEndValue(object newEndValue, float newDuration = -1f /* Metadata: 0x0072E7D3 */, bool snapStartValue = false /* Metadata: 0x0072E7D7 */);
		public abstract Tweener ChangeEndValue(object newEndValue, bool snapStartValue);
		public abstract Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1f /* Metadata: 0x0072E7D8 */);
		internal abstract Tweener SetFrom(bool relative);
		internal static bool Setup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin = null)
			where TPlugOptions : struct, IPlugOptions;
		internal static float DoUpdateDelay<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, float elapsed)
			where TPlugOptions : struct, IPlugOptions;
		internal static bool DoStartup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t)
			where TPlugOptions : struct, IPlugOptions;
		internal static TweenerCore<T1, T2, TPlugOptions> DoChangeStartValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, float newDuration)
			where TPlugOptions : struct, IPlugOptions;
		internal static TweenerCore<T1, T2, TPlugOptions> DoChangeEndValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newEndValue, float newDuration, bool snapStartValue)
			where TPlugOptions : struct, IPlugOptions;
		internal static TweenerCore<T1, T2, TPlugOptions> DoChangeValues<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, T2 newEndValue, float newDuration)
			where TPlugOptions : struct, IPlugOptions;
		private static bool DOStartupSpecials<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t)
			where TPlugOptions : struct, IPlugOptions;
		private static void DOStartupDurationBased<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t)
			where TPlugOptions : struct, IPlugOptions;
	}
}
