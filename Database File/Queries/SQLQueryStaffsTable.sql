CREATE TABLE [dbo].[Staffs] (
    [staff_No]    INT           IDENTITY (1, 1) NOT NULL,
    [surname]     NVARCHAR (50) NOT NULL,
    [first_name]  NVARCHAR (50) NOT NULL,
    [middle_name] NVARCHAR (50) NULL,
    [email]       NVARCHAR (50) NOT NULL,
    [phone_No]    INT           NOT NULL,
    [address]     NVARCHAR (50) NOT NULL,
    [isActive]    BIT           NOT NULL,
    CONSTRAINT [PK__tmp_ms_x__1963B63BAC205F03] PRIMARY KEY CLUSTERED ([staff_No] ASC),
    CONSTRAINT [UKStaffs] UNIQUE NONCLUSTERED ([email] ASC),
    CONSTRAINT [CK_Stafffirst] CHECK (len([first_name])>=(1)),
    CONSTRAINT [CK_Staffssur] CHECK (len([surname])>=(1)),
    CONSTRAINT [CK_Staffsemail] CHECK (len([email])>=(1)),
    CONSTRAINT [CK_Staffsphone] CHECK ([phone_No]<>(0)),
    CONSTRAINT [CK_Staffsaddress] CHECK (len([address])>=(1))
);

