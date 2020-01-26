﻿using RoR2;
using System;
using UnityEngine.Networking;

namespace NetLib
{
    public static partial class Extensions
    {
        public static void Write( this NetworkWriter writer, HurtBoxReference hurtBoxReference )
        {
            NetworkExtensions.Write( writer, hurtBoxReference );
        }
        public static HurtBoxReference ReadHurtBoxReference( this NetworkReader reader )
        {
            return NetworkExtensions.ReadHurtBoxReference( reader );
        }
    }
}