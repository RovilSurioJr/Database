CREATE TABLE [dbo].[Beneficiaries] (
    [beneficiary_No] INT           IDENTITY (1, 1) NOT NULL,
    [surname]        NVARCHAR (50) NOT NULL,
    [first_name]     NVARCHAR (50) NOT NULL,
    [middle_name]    NVARCHAR (50) NULL,
    [email]          NVARCHAR (50) NOT NULL,
    [phone_No]       INT           NOT NULL,
    [address]        NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK__Benefici__CD6416DF35098A36] PRIMARY KEY CLUSTERED ([beneficiary_No] ASC),
    CONSTRAINT [UKBenificiaries] UNIQUE NONCLUSTERED ([email] ASC),
    CONSTRAINT [CK_phone_No_benefi] CHECK ([phone_No]<>(0)),
    CONSTRAINT [CK_surname_benefi] CHECK (len([surname])>=(1)),
    CONSTRAINT [CK_firstname_benefi] CHECK (len([first_name])>=(1)),
    CONSTRAINT [CK_email_benefi] CHECK (len([email])>=(1)),
    CONSTRAINT [CK_address_benifi] CHECK (len([address])>=(1))
);

