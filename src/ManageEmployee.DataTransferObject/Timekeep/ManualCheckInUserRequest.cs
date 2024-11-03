﻿using ManageEmployee.DataTransferObject.PagingRequest;

namespace ManageEmployee.DataTransferObject.Timekeep;

public class ManualCheckInUserRequest : PagingRequestModel
{
    public DateTime? Date { get; set; }
    public int? TargetId { get; set; }
    public DateTime? DateSelected { get; set; }
    public DateTime? DateTimeKeep { get; set; }
}
