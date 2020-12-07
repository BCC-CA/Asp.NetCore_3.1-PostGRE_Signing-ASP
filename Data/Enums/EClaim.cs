﻿using System.ComponentModel;

namespace StartupProject_Asp.NetCore_PostGRE.Data.Enums
{
    public enum EClaim
    {
        //[Display(Name = "Role-Claim Policy")]
        [Description("Role.Create")]
        Role_Create = 0,
        [Description("Role.Read")]
        Role_Read = 0,
        [Description("Role.Update")]
        Role_Update,
        [Description("Role.Delete")]
        Role_Delete
    }
}