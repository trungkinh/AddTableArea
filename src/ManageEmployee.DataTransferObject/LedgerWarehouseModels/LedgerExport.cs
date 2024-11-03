﻿namespace ManageEmployee.DataTransferObject.LedgerWarehouseModels;

public class LedgerExport
{
    public long Id { get; set; }
    public string? Type { get; set; }
    public int Month { get; set; }
    public DateTime? BookDate { get; set; }
    public DateTime? OrginalBookDate { get; set; }
    public string? OrginalVoucherNumber { get; set; }
    public string? OrginalDescription { get; set; }
    public string? OrginalCompanyName { get; set; }
    public string? OrginalAddress { get; set; }
    public string? AttachVoucher { get; set; }
    public string? ReferenceVoucherNumber { get; set; }
    public DateTime? ReferenceBookDate { get; set; }
    public string? ReferenceFullName { get; set; }
    public string? ReferenceAddress { get; set; }
    public string? InvoiceCode { get; set; }
    public string? InvoiceAdditionalDeclarationCode { get; set; }
    public string? InvoiceNumber { get; set; }
    public string? InvoiceTaxCode { get; set; }
    public string? InvoiceAddress { get; set; }
    public string? InvoiceSerial { get; set; }
    public DateTime? InvoiceDate { get; set; }
    public string? InvoiceName { get; set; }
    public string? InvoiceProductItem { get; set; }
    public string? DebitCode { get; set; }
    public string? DebitWarehouse { get; set; }
    public string? DebitDetailCodeFirst { get; set; }
    public string? DebitDetailCodeSecond { get; set; }
    public string? CreditCode { get; set; }
    public string? CreditWarehouse { get; set; }
    public string? CreditDetailCodeFirst { get; set; }
    public string? CreditDetailCodeSecond { get; set; }
    public string? CreditDetailCodeSecondName { get; set; }
    public string? ProjectCode { get; set; }
    public int DepreciaMonth { get; set; } = 0;
    public double Quantity { get; set; } = 0;
    public double UnitPrice { get; set; } = 0;
    public double OrginalCurrency { get; set; } = 0;
    public double ExchangeRate { get; set; } = 0;
    public double Amount { get; set; } = 0;
    public string? DebitCodeName { get; set; }
    public string? DebitDetailCodeFirstName { get; set; }
    public string? DebitDetailCodeSecondName { get; set; }
    public string? CreditCodeName { get; set; }
    public string? CreditDetailCodeFirstName { get; set; }
    public string? DebitWarehouseName { get; set; }
    public string? CreditWarehouseName { get; set; }
    public int? IsInternal { get; set; } = 0;
}
