﻿namespace ManageEmployee.Entities.CarEntities;

public class CarLocationDetail
{
    public int Id { get; set; }
    public int CarLocationId { get; set; }
    public string? LicensePlates { get; set; }
    public string? Type { get; set; }
    public string? Payload { get; set; }
    public string? DriverName { get; set; }
    public string? Location { get; set; }
    public string? PlanInprogress { get; set; }
    public string? PlanExpected { get; set; }
    public string? Note { get; set; }
    public string? FileStr { get; set; }
}