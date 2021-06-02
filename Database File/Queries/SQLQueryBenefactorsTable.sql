CREATE TABLE [dbo].[Benefactors] (
    [benefactor_No] INT           IDENTITY (1, 1) NOT NULL,
    [surname]       NVARCHAR (50) NOT NULL,
    [first_name]    NVARCHAR (50) NOT NULL,
    [middle_name]   NVARCHAR (50) NULL,
    [email]         NVARCHAR (50) NOT NULL,
    [phone_No]      INT           NOT NULL,
    [address]       NVARCHAR (50) NOT NULL,
    [isActive]      BIT           NOT NULL,
    CONSTRAINT [PK__Benefact__6061C99A326CBFD2] PRIMARY KEY CLUSTERED ([benefactor_No] ASC),
    CONSTRAINT [UKbenefactors] UNIQUE NONCLUSTERED ([email] ASC),
    CONSTRAINT [CK_surname] CHECK (len([surname])>=(1)),
    CONSTRAINT [CK_first_name] CHECK (len([first_name])>=(1)),
    CONSTRAINT [CK_email] CHECK (len([email])>=(1)),
    CONSTRAINT [CK_phone_No] CHECK ([phone_No]<>(0)),
    CONSTRAINT [CK_address] CHECK (len([address])>=(1))
);