namespace HospitalManagement.Enums
{
    public enum UserRole
    {
        Admin = 1,
        Doctor = 2,
        Receptionist = 3
    }

    public enum Gender
    {
        Male = 1,
        Female = 2,
        Other = 3
    }

    public enum BloodGroup
    {
        APositive = 1,
        ANegative,
        BPositive,
        BNegative,
        ABPositive,
        ABNegative,
        OPositive,
        ONegative
    }

    public enum AppointmentStatus
    {
        Scheduled = 1,
        Completed,
        Cancelled,
        NoShow
    }

    public enum PaymentStatus
    {
        Pending = 1,
        Partial,
        Paid,
        Failed
    }

    public enum PaymentMethod
    {
        Cash = 1,
        Card,
        Online
    }

    public enum BillingCycle
    {
        Monthly = 1,
        Yearly
    }

    public enum SubscriptionStatus
    {
        Active = 1,
        Cancelled,
        Expired,
        Trial
    }
}