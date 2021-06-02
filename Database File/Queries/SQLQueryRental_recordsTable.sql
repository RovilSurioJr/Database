CREATE TABLE [dbo].[Rental_records] (
    [rental_record_No]      INT           IDENTITY (1, 1) NOT NULL,
    [bike_No]               INT           NOT NULL,
    [beneficiary_No]        INT           NOT NULL,
    [rental_date]           DATETIME      NOT NULL,
    [return_date]           DATETIME      NULL,
    [bike_condition_before] NVARCHAR (50) NOT NULL,
    [bike_condition_after]  NVARCHAR (50) NULL,
    [staff_lender_No]       INT           NOT NULL,
    [staff_receiver_No]     INT           NULL,
    [isValid]               BIT           NOT NULL,
    CONSTRAINT [PK__Rental_r__F70E47DA27D6642A] PRIMARY KEY CLUSTERED ([rental_record_No] ASC),
    CONSTRAINT [FK__Rental_re__custo__2E1BDC42] FOREIGN KEY ([beneficiary_No]) REFERENCES [dbo].[Beneficiaries] ([beneficiary_No]),
    CONSTRAINT [FK__Rental_re__staff__4BAC3F29] FOREIGN KEY ([staff_receiver_No]) REFERENCES [dbo].[Staffs] ([staff_No]),
    CONSTRAINT [FK__Rental_re__staff__4CA06362] FOREIGN KEY ([staff_lender_No]) REFERENCES [dbo].[Staffs] ([staff_No]),
    CONSTRAINT [FK__Rental_re__bike___2D27B809] FOREIGN KEY ([bike_No]) REFERENCES [dbo].[Bikes] ([bike_No]),
    CONSTRAINT [CK_bike_No] CHECK ([bike_No]<>(0)),
    CONSTRAINT [CK_beneficiary_No] CHECK ([beneficiary_No]<>(0)),
    CONSTRAINT [CK_cond_before] CHECK (len([bike_condition_before])>=(1)),
    CONSTRAINT [CK_lender] CHECK ([staff_lender_No]<>(0))
);

