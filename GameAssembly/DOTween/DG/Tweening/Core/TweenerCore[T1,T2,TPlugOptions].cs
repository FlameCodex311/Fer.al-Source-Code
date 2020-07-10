/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

// Image 48: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5511-5701

namespace DG.Tweening.Core
{
	public class TweenerCore<T1, T2, TPlugOptions> : Tweener // TypeDefIndex: 5685
		where TPlugOptions : struct, IPlugOptions
	{
		// Fields
		public T2 startValue;
		public T2 endValue;
		public T2 changeValue;
		public TPlugOptions plugOptions;
		public DOGetter<T1> getter;
		public DOSetter<T1> setter;
		internal ABSTweenPlugin<T1, T2, TPlugOptions> tweenPlugin;
		private const string _TxtCantChangeSequencedValues = "You cannot change the values of a tween contained inside a Sequence"; // Metadata: 0x0072E958
	
		// Constructors
		internal TweenerCore();
	
		// Methods
		public override Tweener ChangeStartValue(object newStartValue, float newDuration = -1f /* Metadata: 0x0072E93E */);
		public override Tweener ChangeEndValue(object newEndValue, bool snapStartValue);
		public override Tweener ChangeEndValue(object newEndValue, float newDuration = -1f /* Metadata: 0x0072E942 */, bool snapStartValue = false /* Metadata: 0x0072E946 */);
		public override Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1f /* Metadata: 0x0072E947 */);
		public TweenerCore<T1, T2, TPlugOptions> ChangeStartValue(T2 newStartValue, float newDuration = -1f /* Metadata: 0x0072E94B */);
		public TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, bool snapStartValue);
		public TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, float newDuration = -1f /* Metadata: 0x0072E94F */, bool snapStartValue = false /* Metadata: 0x0072E953 */);
		public TweenerCore<T1, T2, TPlugOptions> ChangeValues(T2 newStartValue, T2 newEndValue, float newDuration = -1f /* Metadata: 0x0072E954 */);
		internal override Tweener SetFrom(bool relative);
		internal Tweener SetFrom(T2 fromValue, bool setImmediately);
		internal sealed override void Reset();
		internal override bool Validate();
		internal override float UpdateDelay(float elapsed);
		internal override bool Startup();
		internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice);
	}
}
