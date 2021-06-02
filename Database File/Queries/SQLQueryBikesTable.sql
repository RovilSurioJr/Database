CREATE TABLE [dbo].[Bikes] (
    [bike_No]        INT           IDENTITY (1, 1) NOT NULL,
    [bike_model]     NVARCHAR (50) NOT NULL,
    [benefactor_No]  INT           NOT NULL,
    [bike_color]     NVARCHAR (50) NOT NULL,
    [bike_accessory] NVARCHAR (50) NOT NULL,
    [bike_condition] NVARCHAR (50) NOT NULL,
    [donation_date]  DATETIME      NOT NULL,
    [isActive]       BIT           NOT NULL,
    CONSTRAINT [PK__Bikes__ADA0502C3061740E] PRIMARY KEY CLUSTERED ([bike_No] ASC),
    CONSTRAINT [FK__Bikes__benefacto__267ABA7A] FOREIGN KEY ([benefactor_No]) REFERENCES [dbo].[Benefactors] ([benefactor_No]),
    CONSTRAINT [CK_bike_model] CHECK (len([bike_model])>=(1)),
    CONSTRAINT [CK_benefactor] CHECK (len([benefactor_No])>=(1)),
    CONSTRAINT [CK_color] CHECK (len([bike_color])>=(1)),
    CONSTRAINT [CK_acc] CHECK (len([bike_accessory])>=(1)),
    CONSTRAINT [CK_cond] CHECK (len([bike_condition])>=(1))
);

