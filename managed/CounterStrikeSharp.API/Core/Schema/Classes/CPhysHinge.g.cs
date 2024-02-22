// <auto-generated />
#nullable enable
#pragma warning disable CS1591

using System;
using System.Diagnostics;
using System.Drawing;
using CounterStrikeSharp;
using CounterStrikeSharp.API.Modules.Events;
using CounterStrikeSharp.API.Modules.Entities;
using CounterStrikeSharp.API.Modules.Memory;
using CounterStrikeSharp.API.Modules.Utils;
using CounterStrikeSharp.API.Core.Attributes;

namespace CounterStrikeSharp.API.Core;

public partial class CPhysHinge : CPhysConstraint
{
    public CPhysHinge (IntPtr pointer) : base(pointer) {}

	// m_soundInfo
	[SchemaMember("CPhysHinge", "m_soundInfo")]
	public ConstraintSoundInfo SoundInfo => Schema.GetDeclaredClass<ConstraintSoundInfo>(this.Handle, "CPhysHinge", "m_soundInfo");

	// m_NotifyMinLimitReached
	[SchemaMember("CPhysHinge", "m_NotifyMinLimitReached")]
	public CEntityIOOutput NotifyMinLimitReached => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CPhysHinge", "m_NotifyMinLimitReached");

	// m_NotifyMaxLimitReached
	[SchemaMember("CPhysHinge", "m_NotifyMaxLimitReached")]
	public CEntityIOOutput NotifyMaxLimitReached => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CPhysHinge", "m_NotifyMaxLimitReached");

	// m_bAtMinLimit
	[SchemaMember("CPhysHinge", "m_bAtMinLimit")]
	public ref bool AtMinLimit => ref Schema.GetRef<bool>(this.Handle, "CPhysHinge", "m_bAtMinLimit");

	// m_bAtMaxLimit
	[SchemaMember("CPhysHinge", "m_bAtMaxLimit")]
	public ref bool AtMaxLimit => ref Schema.GetRef<bool>(this.Handle, "CPhysHinge", "m_bAtMaxLimit");

	// m_hinge
	[SchemaMember("CPhysHinge", "m_hinge")]
	public constraint_hingeparams_t Hinge => Schema.GetDeclaredClass<constraint_hingeparams_t>(this.Handle, "CPhysHinge", "m_hinge");

	// m_hingeFriction
	[SchemaMember("CPhysHinge", "m_hingeFriction")]
	public ref float HingeFriction => ref Schema.GetRef<float>(this.Handle, "CPhysHinge", "m_hingeFriction");

	// m_systemLoadScale
	[SchemaMember("CPhysHinge", "m_systemLoadScale")]
	public ref float SystemLoadScale => ref Schema.GetRef<float>(this.Handle, "CPhysHinge", "m_systemLoadScale");

	// m_bIsAxisLocal
	[SchemaMember("CPhysHinge", "m_bIsAxisLocal")]
	public ref bool IsAxisLocal => ref Schema.GetRef<bool>(this.Handle, "CPhysHinge", "m_bIsAxisLocal");

	// m_flMinRotation
	[SchemaMember("CPhysHinge", "m_flMinRotation")]
	public ref float MinRotation => ref Schema.GetRef<float>(this.Handle, "CPhysHinge", "m_flMinRotation");

	// m_flMaxRotation
	[SchemaMember("CPhysHinge", "m_flMaxRotation")]
	public ref float MaxRotation => ref Schema.GetRef<float>(this.Handle, "CPhysHinge", "m_flMaxRotation");

	// m_flInitialRotation
	[SchemaMember("CPhysHinge", "m_flInitialRotation")]
	public ref float InitialRotation => ref Schema.GetRef<float>(this.Handle, "CPhysHinge", "m_flInitialRotation");

	// m_flMotorFrequency
	[SchemaMember("CPhysHinge", "m_flMotorFrequency")]
	public ref float MotorFrequency => ref Schema.GetRef<float>(this.Handle, "CPhysHinge", "m_flMotorFrequency");

	// m_flMotorDampingRatio
	[SchemaMember("CPhysHinge", "m_flMotorDampingRatio")]
	public ref float MotorDampingRatio => ref Schema.GetRef<float>(this.Handle, "CPhysHinge", "m_flMotorDampingRatio");

	// m_flAngleSpeed
	[SchemaMember("CPhysHinge", "m_flAngleSpeed")]
	public ref float AngleSpeed => ref Schema.GetRef<float>(this.Handle, "CPhysHinge", "m_flAngleSpeed");

	// m_flAngleSpeedThreshold
	[SchemaMember("CPhysHinge", "m_flAngleSpeedThreshold")]
	public ref float AngleSpeedThreshold => ref Schema.GetRef<float>(this.Handle, "CPhysHinge", "m_flAngleSpeedThreshold");

	// m_OnStartMoving
	[SchemaMember("CPhysHinge", "m_OnStartMoving")]
	public CEntityIOOutput OnStartMoving => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CPhysHinge", "m_OnStartMoving");

	// m_OnStopMoving
	[SchemaMember("CPhysHinge", "m_OnStopMoving")]
	public CEntityIOOutput OnStopMoving => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CPhysHinge", "m_OnStopMoving");

}