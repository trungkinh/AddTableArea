﻿namespace ManageEmployee.DataTransferObject.WarehouseModel;

public class WareHouseShelvesPaging
{
    public int Id { get; set; }
    public string? Code { get; set; }
    public string? Name { get; set; }
    public string? Note { get; set; }
    public int OrderHorizontal { get; set; }
    public int OrderVertical { get; set; }
    public string? Floors { get; set; }
}
