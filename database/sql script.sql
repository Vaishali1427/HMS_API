USE [hms]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 20/07/2023 18:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[Dept_Id] [varchar](20) NOT NULL,
	[Dept_Name] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Dept_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient_Diagnosis]    Script Date: 20/07/2023 18:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient_Diagnosis](
	[Patient_Id] [int] NOT NULL,
	[Diagnosis_Id] [int] NOT NULL,
	[Symptoms] [varchar](30) NOT NULL,
	[Diagnosis_Provided] [varchar](500) NOT NULL,
	[Physician_Visited] [varchar](30) NOT NULL,
	[Date_of_diag] [date] NOT NULL,
	[Followup_Req] [varchar](10) NOT NULL,
	[Follow_Date] [date] NOT NULL,
	[Bill_Amt] [float] NOT NULL,
	[Card_No] [varchar](20) NOT NULL,
	[Mode_of_Pay] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Diagnosis_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient_Enroll]    Script Date: 20/07/2023 18:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient_Enroll](
	[Patient_Id] [int] NOT NULL,
	[Patient_FName] [varchar](30) NOT NULL,
	[Patient_LName] [varchar](30) NOT NULL,
	[Patient_Dob] [date] NOT NULL,
	[Patient_Email] [varchar](50) NOT NULL,
	[Patient_Contact] [varchar](20) NOT NULL,
	[Patient_State] [varchar](20) NOT NULL,
	[Insurance] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Patient_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Physician_Enroll]    Script Date: 20/07/2023 18:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Physician_Enroll](
	[Phy_Id] [varchar](30) NOT NULL,
	[Phy_Fname] [varchar](30) NOT NULL,
	[Phy_Lname] [varchar](30) NOT NULL,
	[Dept_Id] [varchar](20) NOT NULL,
	[Phy_Exp] [real] NOT NULL,
	[Phy_State] [varchar](20) NOT NULL,
	[InsurancePlan] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Phy_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[physician_search]    Script Date: 20/07/2023 18:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[physician_search](
	[Phy_Id] [varchar](30) NOT NULL,
	[phy_state] [varchar](20) NULL,
	[phy_plan] [varchar](40) NULL,
	[department_id] [varchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 20/07/2023 18:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERS](
	[Username] [varchar](20) NOT NULL,
	[User_Password] [varchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[view_patient_history]    Script Date: 20/07/2023 18:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[view_patient_history](
	[Patient_Id] [int] NOT NULL,
	[firstname] [varchar](50) NOT NULL,
	[lastname] [varchar](50) NOT NULL,
	[Phy_Id] [varchar](30) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Department] ([Dept_Id], [Dept_Name]) VALUES (N'D001', N'Cardiology')
INSERT [dbo].[Department] ([Dept_Id], [Dept_Name]) VALUES (N'D003', N'Ophthalmology')
INSERT [dbo].[Department] ([Dept_Id], [Dept_Name]) VALUES (N'D004', N'Dermatology')
INSERT [dbo].[Department] ([Dept_Id], [Dept_Name]) VALUES (N'D005', N'Neurology')
GO
INSERT [dbo].[Patient_Diagnosis] ([Patient_Id], [Diagnosis_Id], [Symptoms], [Diagnosis_Provided], [Physician_Visited], [Date_of_diag], [Followup_Req], [Follow_Date], [Bill_Amt], [Card_No], [Mode_of_Pay]) VALUES (1, 5, N'string', N'string', N'string', CAST(N'2023-07-12' AS Date), N'string', CAST(N'2023-07-12' AS Date), 0, N'string', N'string')
INSERT [dbo].[Patient_Diagnosis] ([Patient_Id], [Diagnosis_Id], [Symptoms], [Diagnosis_Provided], [Physician_Visited], [Date_of_diag], [Followup_Req], [Follow_Date], [Bill_Amt], [Card_No], [Mode_of_Pay]) VALUES (1, 123, N'FEVER', N'Common Cold', N'Dr.Siddharth Mukharjee', CAST(N'2023-04-02' AS Date), N'yes', CAST(N'2023-04-07' AS Date), 10050, N'XXXXXX0987', N'DEBIT CARD')
INSERT [dbo].[Patient_Diagnosis] ([Patient_Id], [Diagnosis_Id], [Symptoms], [Diagnosis_Provided], [Physician_Visited], [Date_of_diag], [Followup_Req], [Follow_Date], [Bill_Amt], [Card_No], [Mode_of_Pay]) VALUES (2, 456, N'MALARIA', N'FEVER', N'Dr.Naresh Trehan', CAST(N'2023-05-02' AS Date), N'yes', CAST(N'2023-05-07' AS Date), 6000, N'XXXXXX4567', N'DEBIT CARD')
INSERT [dbo].[Patient_Diagnosis] ([Patient_Id], [Diagnosis_Id], [Symptoms], [Diagnosis_Provided], [Physician_Visited], [Date_of_diag], [Followup_Req], [Follow_Date], [Bill_Amt], [Card_No], [Mode_of_Pay]) VALUES (5, 654, N'FATIGUE', N'SICKNESS', N'Dr.Sudhanshu Anand', CAST(N'2023-02-02' AS Date), N'yes', CAST(N'2023-02-07' AS Date), 11000, N'135790', N'CASH')
INSERT [dbo].[Patient_Diagnosis] ([Patient_Id], [Diagnosis_Id], [Symptoms], [Diagnosis_Provided], [Physician_Visited], [Date_of_diag], [Followup_Req], [Follow_Date], [Bill_Amt], [Card_No], [Mode_of_Pay]) VALUES (3, 789, N'DIARRHEA', N'STOMACH INFECTION', N'Dr.Puja singh', CAST(N'2022-11-02' AS Date), N'No', CAST(N'2022-11-07' AS Date), 7500, N'XXXXXX6578', N'GOOGLE PAY')
INSERT [dbo].[Patient_Diagnosis] ([Patient_Id], [Diagnosis_Id], [Symptoms], [Diagnosis_Provided], [Physician_Visited], [Date_of_diag], [Followup_Req], [Follow_Date], [Bill_Amt], [Card_No], [Mode_of_Pay]) VALUES (4, 987, N'HEADACHE', N'BRAIN HEAMORRAGE', N'Dr.Siddhart Mukharjee', CAST(N'2022-12-02' AS Date), N'yes', CAST(N'2022-12-07' AS Date), 8000, N'XXXXXX1984', N'PHONEPE')
GO
INSERT [dbo].[Patient_Enroll] ([Patient_Id], [Patient_FName], [Patient_LName], [Patient_Dob], [Patient_Email], [Patient_Contact], [Patient_State], [Insurance]) VALUES (1, N'Vaishali', N'Pandey', CAST(N'2002-09-04' AS Date), N'vaishalipandey@gmail.com', N'9876543210', N'Uttarpradesh', N'Life Insurance')
INSERT [dbo].[Patient_Enroll] ([Patient_Id], [Patient_FName], [Patient_LName], [Patient_Dob], [Patient_Email], [Patient_Contact], [Patient_State], [Insurance]) VALUES (2, N'Ayush', N'Kumar', CAST(N'2002-05-03' AS Date), N'ayushkumar@gmail.com', N'8976543210', N'Jharkhand', N'Life Insurance')
INSERT [dbo].[Patient_Enroll] ([Patient_Id], [Patient_FName], [Patient_LName], [Patient_Dob], [Patient_Email], [Patient_Contact], [Patient_State], [Insurance]) VALUES (3, N'Anil', N'Hegde', CAST(N'1999-04-01' AS Date), N'anilHegde@gmail.com', N'7896543210', N'Karnataka', N'Medical Insurance')
INSERT [dbo].[Patient_Enroll] ([Patient_Id], [Patient_FName], [Patient_LName], [Patient_Dob], [Patient_Email], [Patient_Contact], [Patient_State], [Insurance]) VALUES (4, N'Venkatesh', N'Prasad', CAST(N'1998-12-04' AS Date), N'vanketeshprashad@gmail.com', N'6789543210', N'Hyderabad', N'HDFC Insurance')
INSERT [dbo].[Patient_Enroll] ([Patient_Id], [Patient_FName], [Patient_LName], [Patient_Dob], [Patient_Email], [Patient_Contact], [Patient_State], [Insurance]) VALUES (5, N'K', N'Harshitha', CAST(N'2001-11-02' AS Date), N'harshita@gmail.com', N'8967452310', N'Karnataka', N'Max Insurance')
INSERT [dbo].[Patient_Enroll] ([Patient_Id], [Patient_FName], [Patient_LName], [Patient_Dob], [Patient_Email], [Patient_Contact], [Patient_State], [Insurance]) VALUES (6, N'Ravi', N'Gupta', CAST(N'2000-11-30' AS Date), N'ravi@gmail.com', N'9987654321', N'Chhattisgarh', N'Life Insurance')
GO
INSERT [dbo].[Physician_Enroll] ([Phy_Id], [Phy_Fname], [Phy_Lname], [Dept_Id], [Phy_Exp], [Phy_State], [InsurancePlan]) VALUES (N'PH001', N'Dr.Siddharth', N'Mukharjee', N'D001', 17, N'New Delhi', N'LIC Bima Jyoti')
INSERT [dbo].[Physician_Enroll] ([Phy_Id], [Phy_Fname], [Phy_Lname], [Dept_Id], [Phy_Exp], [Phy_State], [InsurancePlan]) VALUES (N'PH002', N'Dr.Naresh', N'Trehan', N'D003', 12, N'Rajasthan', N'LIC Bima Ratna')
INSERT [dbo].[Physician_Enroll] ([Phy_Id], [Phy_Fname], [Phy_Lname], [Dept_Id], [Phy_Exp], [Phy_State], [InsurancePlan]) VALUES (N'PH003', N'Dr.Sudhanshu', N'Anand', N'D004', 8, N'Hyderabad', N'LIC Jeevan Azad')
INSERT [dbo].[Physician_Enroll] ([Phy_Id], [Phy_Fname], [Phy_Lname], [Dept_Id], [Phy_Exp], [Phy_State], [InsurancePlan]) VALUES (N'PH004', N'Dr.Pooja', N'Singh', N'D005', 13, N'Bihar', N'LIC Aadhaar Stambh')
INSERT [dbo].[Physician_Enroll] ([Phy_Id], [Phy_Fname], [Phy_Lname], [Dept_Id], [Phy_Exp], [Phy_State], [InsurancePlan]) VALUES (N'PH006', N' Dr. Saurabh', N'Sharma', N'D004', 12, N'Maharashtra', N'LIC Jeevan Bima')
GO
INSERT [dbo].[physician_search] ([Phy_Id], [phy_state], [phy_plan], [department_id]) VALUES (N'PH001', N'New Delhi', N'LIC Bima Jyoti', N'D002')
INSERT [dbo].[physician_search] ([Phy_Id], [phy_state], [phy_plan], [department_id]) VALUES (N'PH002', N'Rajasthan', N'LIC Bima Ratna', N'D003')
INSERT [dbo].[physician_search] ([Phy_Id], [phy_state], [phy_plan], [department_id]) VALUES (N'PH003', N'Hyderabad', N'LIC Jeevan Azad', N'D004')
INSERT [dbo].[physician_search] ([Phy_Id], [phy_state], [phy_plan], [department_id]) VALUES (N'PH004', N'Bihar', N'LIC Adhaar Stambh', N'D005')
GO
INSERT [dbo].[USERS] ([Username], [User_Password]) VALUES (N'Vaishali01', N'admin1')
INSERT [dbo].[USERS] ([Username], [User_Password]) VALUES (N'Ayush02', N'admin2')
INSERT [dbo].[USERS] ([Username], [User_Password]) VALUES (N'Anil03', N'admin3')
INSERT [dbo].[USERS] ([Username], [User_Password]) VALUES (N'Venkatesh04', N'admin4')
INSERT [dbo].[USERS] ([Username], [User_Password]) VALUES (N'Harshitha05', N'admin5')
GO
INSERT [dbo].[view_patient_history] ([Patient_Id], [firstname], [lastname], [Phy_Id]) VALUES (1, N'Vaishali', N'Pandey', N'PH001')
INSERT [dbo].[view_patient_history] ([Patient_Id], [firstname], [lastname], [Phy_Id]) VALUES (2, N'Ayush', N'Kumar', N'PH002')
INSERT [dbo].[view_patient_history] ([Patient_Id], [firstname], [lastname], [Phy_Id]) VALUES (3, N'Anil', N'Hegde', N'PH003')
INSERT [dbo].[view_patient_history] ([Patient_Id], [firstname], [lastname], [Phy_Id]) VALUES (4, N'Venkatesh', N'Prasad', N'PH004')
GO
ALTER TABLE [dbo].[Patient_Diagnosis]  WITH CHECK ADD FOREIGN KEY([Patient_Id])
REFERENCES [dbo].[Patient_Enroll] ([Patient_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Physician_Enroll]  WITH CHECK ADD FOREIGN KEY([Dept_Id])
REFERENCES [dbo].[Department] ([Dept_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[physician_search]  WITH CHECK ADD FOREIGN KEY([Phy_Id])
REFERENCES [dbo].[Physician_Enroll] ([Phy_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[view_patient_history]  WITH CHECK ADD FOREIGN KEY([Patient_Id])
REFERENCES [dbo].[Patient_Enroll] ([Patient_Id])
GO
ALTER TABLE [dbo].[view_patient_history]  WITH CHECK ADD FOREIGN KEY([Phy_Id])
REFERENCES [dbo].[Physician_Enroll] ([Phy_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
/****** Object:  StoredProcedure [dbo].[AddDiagnosisDetails]    Script Date: 20/07/2023 18:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddDiagnosisDetails]
@Patient_Id int,
@Diagnosis_Id int,
@Symptoms varchar(30),
@Diagnosis_Provided varchar(500),
@Physician_Visited varchar(30),
@Date_of_diag Date,
@Followup_Req varchar(10),
@Follow_Date Date,
@Bill_Amt float,
@Card_No varchar(20),
@Mode_of_Pay varchar(10) 
AS
BEGIN
INSERT INTO Patient_Diagnosis(Patient_Id, Diagnosis_Id, Symptoms, Diagnosis_Provided, Physician_Visited, Date_of_diag, Followup_Req, Follow_Date, Bill_Amt, Card_No, Mode_of_Pay)
VALUES (@Patient_Id, @Diagnosis_Id, @Symptoms, @Diagnosis_Provided, @Physician_Visited, @Date_of_diag, @Followup_Req, @Follow_Date, @Bill_Amt, @Card_No, @Mode_of_Pay)
end
GO
/****** Object:  StoredProcedure [dbo].[AddPatient]    Script Date: 20/07/2023 18:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AddPatient]
@Patient_Id int,
@Patient_FName varchar(30),
@Patient_LName varchar(30),
@Patient_Dob Date,
@Patient_Email varchar(50),
@Patient_Contact varchar(20),
@Patient_State varchar(20),
@Insurance varchar(20)

AS
BEGIN
SET NOCOUNT ON;
INSERT INTO Patient_Enroll(Patient_Id, Patient_FName, Patient_LName, Patient_Dob, Patient_Email, Patient_Contact, Patient_State, Insurance)
VALUES (@Patient_Id, @Patient_FName, @Patient_LName, @Patient_Dob, @Patient_Email, @Patient_Contact, @Patient_State, @Insurance)
END
GO
/****** Object:  StoredProcedure [dbo].[AddPhysicianDetails]    Script Date: 20/07/2023 18:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AddPhysicianDetails]
@Phy_Id VARCHAR(30),
@Phy_Fname VARCHAR(30),
@Phy_Lname VARCHAR(30),
@Dept_Id varchar(20),
@Phy_Exp float(2),
@Phy_State varchar(20),
@InsurancePlan varchar(20)
AS
BEGIN
insert into Physician_Enroll(Phy_Id, Phy_Fname, Phy_Lname, Dept_Id, Phy_Exp, Phy_State, InsurancePlan)
values (@Phy_Id, @Phy_Fname, @Phy_Lname, @Dept_Id, @Phy_Exp, @Phy_State, @InsurancePlan)
End
GO
/****** Object:  StoredProcedure [dbo].[GetAllPhysicianInsurance]    Script Date: 20/07/2023 18:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllPhysicianInsurance]
AS
BEGIN
SELECT InsurancePlan FROM Physician_Enroll
END
GO
/****** Object:  StoredProcedure [dbo].[GetDepartment]    Script Date: 20/07/2023 18:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetDepartment]
AS 
BEGIN
SELECT * FROM Department
END
GO
/****** Object:  StoredProcedure [dbo].[GetInsurance]    Script Date: 20/07/2023 18:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetInsurance]
@Patient_Id int 
AS
BEGIN
select Insurance from Patient_Enroll where Patient_Id = @Patient_Id
end
GO
/****** Object:  StoredProcedure [dbo].[GetPhysician]    Script Date: 20/07/2023 18:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPhysician]
@Phy_State varchar(20),
@Dept_Id varchar(20),
@InsurancePlan varchar(20)
AS
BEGIN
SELECT Phy_Id, concat(Phy_Fname, ' ', Phy_Lname) as Phy_Name 
FROM Physician_Enroll
WHERE Phy_State = @Phy_State and Dept_Id = @Dept_Id and InsurancePlan = @InsurancePlan
END
GO
/****** Object:  StoredProcedure [dbo].[GetPhysicianInsurance]    Script Date: 20/07/2023 18:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPhysicianInsurance]
@Phy_Id varchar(30)
AS
BEGIN
select InsurancePlan from Physician_Enroll where Phy_Id = @Phy_Id
end
GO
/****** Object:  StoredProcedure [dbo].[GetPhysicianVisitedDetails]    Script Date: 20/07/2023 18:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPhysicianVisitedDetails]
AS
BEGIN
SELECT Physician_Visited FROM Patient_Diagnosis
END
GO
/****** Object:  StoredProcedure [dbo].[GetSymptoms]    Script Date: 20/07/2023 18:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetSymptoms]
AS
BEGIN
SELECT Symptoms from Patient_Diagnosis
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateDepartmentDetails]    Script Date: 20/07/2023 18:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateDepartmentDetails]
@Dept_Id varchar(20),
@Dept_name VARCHAR(20),
@Search varchar(20)
AS
Begin
UPDATE Department SET Dept_Id = @Dept_Id, Dept_Name = @Dept_Name WHERE Dept_Name = @Search
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateInsurance]    Script Date: 20/07/2023 18:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateInsurance]
@Insurance varchar(20),
@Patient_Id int
AS
BEGIN
IF NOT EXISTS (SELECT 1 FROM Patient_Enroll where Patient_Id = @Patient_Id)
BEGIN
DECLARE @ErrorMessage varchar(50)
SET @ErrorMessage = 'Patient Id does not exist.'
RAISERROR (@ErrorMessage, 16, 1)
RETURN
END
update Patient_Enroll
SET Insurance = @Insurance 
where Patient_Id = @Patient_Id
END
GO
/****** Object:  StoredProcedure [dbo].[USERLOGIN]    Script Date: 20/07/2023 18:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USERLOGIN]
@Username varchar(20),
@User_Password varchar(20)
AS
BEGIN
SELECT COUNT(*) FROM users WHERE Username = @Username AND User_Password = @User_Password
END
GO
/****** Object:  StoredProcedure [dbo].[ViewPatientHistory]    Script Date: 20/07/2023 18:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewPatientHistory]
AS
BEGIN
SELECT * FROM view_patient_history
end
GO
