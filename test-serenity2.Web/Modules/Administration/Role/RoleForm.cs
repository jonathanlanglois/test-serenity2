﻿namespace test_serenity2.Administration.Forms;

[FormScript("Administration.Role")]
[BasedOnRow(typeof(RoleRow), CheckNames = true)]
public class RoleForm
{
    public string RoleName { get; set; }
}