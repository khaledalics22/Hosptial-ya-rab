-- _   _                 _ _        _   ____        _        ____                 
--| | | | ___  ___ _ __ (_) |_ __ _| | |  _ \  __ _| |_ __ _| __ )  __ _ ___  ___ 
--| |_| |/ _ \/ __| '_ \| | __/ _` | | | | | |/ _` | __/ _` |  _ \ / _` / __|/ _ \
--|  _  | (_) \__ \ |_) | | || (_| | | | |_| | (_| | || (_| | |_) | (_| \__ \  __/
--|_| |_|\___/|___/ .__/|_|\__\__,_|_| |____/ \__,_|\__\__,_|____/ \__,_|___/\___|
--                |_|                                                             


--create database Hospital
Create database Hospital
GO
use Hospital


					-- _____     _     _           
					--|_   _|_ _| |__ | | ___  ___ 
					--  | |/ _` | '_ \| |/ _ \/ __|
					--  | | (_| | |_) | |  __/\__ \
					--  |_|\__,_|_.__/|_|\___||___/
                              

CREATE TABLE [dbo].[Doctor](
	[Dssn] [int] NOT NULL,
	[Fname] [varchar](50) NOT NULL,
	[Lname] [varchar](50) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[Salary] [int] NOT NULL,
	[City] [varchar](50) NOT NULL,
	[Street] [varchar](50) NOT NULL,
	[House_Num] [int] NOT NULL,
	[Shift_From] [time](0) NOT NULL,
	[Shift_To] [time](0) NOT NULL,
	[Dno] [int] NULL,
	[EndDate] [date] NULL,
	primary key(DSSN)
)


CREATE TABLE [dbo].[Appointment](
	[AID] [int] NOT NULL,
	[Dssn] [int] NOT NULL,
	[Pssn] [int] NOT NULL,
	[Date_Time] [smalldatetime] NOT NULL,
	[Diagnose] [varchar](50) NULL,
	[Canceled] [varchar](50) NOT NULL DEFAULT 'FALSE',
	primary key(AID)
)

CREATE TABLE [dbo].[Clinic](
	[CID] [int] NOT NULL,
	[Floor] [int] NOT NULL,
	[numInFloor] [int] NOT NULL,
	primary key(CID)
)

CREATE TABLE [dbo].[Department](
	[Dnum] [int] NOT NULL,
	[Dname] [varchar](50) UNIQUE NOT NULL,
	primary key(Dnum)
)

CREATE TABLE [dbo].[Dependencies](
	[Name] [varchar](50) NOT NULL,
	[Pssn] [int] NOT NULL,
	[Age] [int] NOT NULL,
	[Phone] [varchar](50) NULL,
	[Relation] [varchar](50) NOT NULL,
	primary key(Name, Pssn)
)

CREATE TABLE [dbo].[DependentDiagnose](
	[Name] [varchar](50) NOT NULL,
	[Pssn] [int] NOT NULL,
	[Diagnose] [varchar](50) NOT NULL,
	primary key(Name, Pssn, Diagnose)
)
CREATE TABLE [dbo].[Doc_Room](
	[Dssn] [int] NOT NULL,
	[RID] [int] NOT NULL,
	primary key(Dssn, RID)
)


CREATE TABLE [dbo].[Drugs](
	[Code] [int] NOT NULL,
	[Name] [varchar](50) UNIQUE NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [float] NOT NULL,
	primary key(Code)
)

CREATE TABLE [dbo].[Employee](
	[ESSN] [int] NOT NULL,
	[Fname] [varchar](50) NOT NULL,
	[Lname] [varchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[Salary] [int] NOT NULL,
	[Certificate] [varchar](50) NULL,
	[Job] [varchar](50) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
	[Shift_From] [time](0) NOT NULL,
	[Shift_To] [time](0) NOT NULL,
	[Dno] [int] NULL,
	primary key(ESSN)
)

CREATE TABLE [dbo].[Nurse](
	[Nssn] [int] NOT NULL,
	[Fname] [varchar](50) NOT NULL,
	[Lname] [varchar](50) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[Salary] [int] NOT NULL,
	[Shift_From] [time](0) NOT NULL,
	[Shift_To] [time](0) NOT NULL,
	[EndDate] [date] NULL,
	primary key(Nssn)
)
CREATE TABLE [dbo].[Nurse_Room](
	[Nssn] [int] NOT NULL,
	[RID] [int] NOT NULL,
	primary key(Nssn, RID)
)
CREATE TABLE [dbo].[Patient](
	[Pssn] [int] NOT NULL,
	[Fname] [varchar](50) NOT NULL,
	[Lname] [varchar](50) NOT NULL,
	[Insurance] [varchar](50) NULL,
	[Age] [int] NULL,
	[Phone] [varchar](50) NOT NULL,
	[City] [varchar](50) NULL,
	[Street] [varchar](50) NULL,
	primary key(Pssn)
)
CREATE TABLE [dbo].[Patient_Medicine](
	[AID] [int] NOT NULL,
	[medicine] [varchar](50) NOT NULL,
	primary key(AID, medicine)
)
CREATE TABLE [dbo].[PatientDiagnose](
	[Pssn] [int] NOT NULL,
	[Diagnose] [varchar](50) NOT NULL,
	primary key(Pssn, Diagnose)
)
CREATE TABLE [dbo].[Reservation](
	[Pssn] [int] NOT NULL,
	[RID] [int] NOT NULL,
	[Sdate] [date] NOT NULL,
	[Edate] [date] NOT NULL,
	primary key(Pssn, RID, Sdate)
)
CREATE TABLE [dbo].[Room](
	[RID] [int] NOT NULL,
	[Floor] [int] NOT NULL,
	[numInFloor] [int] NOT NULL,
	[Capacity] [int] NOT NULL DEFAULT 1,
	primary key(RID)
)
CREATE TABLE [dbo].[SoldDrugs](
	[Code] [int] NOT NULL,
	[Date] [date] NOT NULL,
	primary key(Code, [Date])
)
CREATE TABLE [dbo].[Doctor_Clinic](
	[Dssn] [int] UNIQUE NOT NULL,
	[CID] [int] NOT NULL,
	[StartTime] [time](0) NOT NULL,
	[EndTime] [time](0) NOT NULL,
	primary key(CID, StartTime)
)

CREATE TABLE [dbo].[Nurse_Clinic](
	[Nssn] [int] UNIQUE NOT NULL,
	[CID] [int] NOT NULL,
	[StartTime] [time](0) NOT NULL,
	[EndTime] [time](0) NOT NULL,
	primary key(CID, StartTime)
)


					-- ____      _       _   _                 
					--|  _ \ ___| | __ _| |_(_) ___  _ __  ___ 
					--| |_) / _ \ |/ _` | __| |/ _ \| '_ \/ __|
					--|  _ <  __/ | (_| | |_| | (_) | | | \__ \
					--|_| \_\___|_|\__,_|\__|_|\___/|_| |_|___/
                                          

alter table Doctor add foreign key (Dno) references Department 
ON DELETE SET NULL ON UPDATE CASCADE;

alter table Employee add foreign key (Dno) references Department
ON DELETE SET NULL ON UPDATE CASCADE;

alter table Appointment add foreign key (Dssn) references Doctor
ON DELETE CASCADE ON UPDATE CASCADE;

alter table Appointment add foreign key (Pssn) references Patient
ON DELETE CASCADE ON UPDATE CASCADE;

alter table Dependencies add foreign key (Pssn) references Patient
ON DELETE CASCADE ON UPDATE CASCADE;

alter table Doc_Room add foreign key (Dssn) references Doctor
ON DELETE CASCADE ON UPDATE CASCADE;

alter table Nurse_Room add foreign key (Nssn) references Nurse
ON DELETE CASCADE ON UPDATE CASCADE;

alter table Reservation add foreign key (Pssn) references Patient
ON DELETE CASCADE ON UPDATE CASCADE;

alter table Reservation add foreign key (RID) references Room
ON DELETE CASCADE ON UPDATE CASCADE;

alter table SoldDrugs add foreign key (Code) references Drugs
ON DELETE NO ACTION ON UPDATE CASCADE;

alter table DependentDiagnose add foreign key ([Name], Pssn) references Dependencies
ON DELETE CASCADE ON UPDATE CASCADE;

alter table PatientDiagnose add foreign key (Pssn) references Patient
ON DELETE CASCADE ON UPDATE CASCADE;

alter table Patient_Medicine add foreign key (AID) references Appointment
ON DELETE CASCADE ON UPDATE CASCADE;

alter table Doctor_Clinic add foreign key (Dssn) references Doctor
ON DELETE CASCADE ON UPDATE CASCADE;

alter table Nurse_Clinic add foreign key (Nssn) references Nurse
ON DELETE CASCADE ON UPDATE CASCADE;

alter table Doc_Room add foreign key (RID) references Room
ON DELETE CASCADE ON UPDATE CASCADE;

alter table Nurse_Room add foreign key (RID) references Room
ON DELETE CASCADE ON UPDATE CASCADE;

alter table Doctor_Clinic add foreign key (CID) references Clinic
ON DELETE CASCADE ON UPDATE CASCADE;

alter table Nurse_Clinic add foreign key (CID) references Clinic
ON DELETE CASCADE ON UPDATE CASCADE;

					-- ___                     _   _             
					--|_ _|_ __  ___  ___ _ __| |_(_) ___  _ __  
					-- | || '_ \/ __|/ _ \ '__| __| |/ _ \| '_ \ 
					-- | || | | \__ \  __/ |  | |_| | (_) | | | |
					--|___|_| |_|___/\___|_|   \__|_|\___/|_| |_|
                                            

insert into Department
values
(1, 'Orthopaedics'),
(2, 'Pharmacy'),
(3, 'Physiotherapy'),
(4, 'Emergency'),
(5, 'Surgery'),
(6, 'Ophthalmology'),
(7, 'Neurology'),
(8, 'Accounting'),
(9, 'Reception'),
(10, 'Cleaning')
--(11, 'Neonatal'),
--(12, 'Maternity'),
--(13, 'Radiology'),
--(14, 'Gastroenterology'),
--(15, 'Critical Care'),
--(16, 'Cardiology'),
--(17, 'Anesthetics'),
--(18, 'Urology'),
--(19, 'Nephrology'),
--(20, 'Rheumatology')


insert into Employee
values
(101, 'Ahmed', 'Sameh', 26, 2400, 'Diploma', 'Accountant', '01014589632', '06:00:00', '15:00:00', 8),
(102, 'Farah', 'Ahmed', 34, 3200, 'High School', 'Receptionist', '01154783214', '06:00:00', '15:00:00', 9),
(103, 'Islam', 'Foaad', 40, 5000, 'Diploma', 'Receptionist', '01552186321', '15:00:00', '00:00:00', 9),
(104, 'Ahmed', 'Mohamed', 53, 1800, 'High School', 'Clean worker', '01254896321', '15:00:00', '00:00:00', 10),
(105, 'Ramy', 'Farid', 36, 2800, 'Bachelor', 'Receptionist', '01521489647', '06:00:00', '15:00:00', 9),
(106, 'Samy', 'Sherif', 24, 3000, 'Bachelor', 'Accountant', '01054879632', '15:00:00', '00:00:00', 8),
(107, 'Andrew', 'Moheb', 23, 2900, 'Diploma', 'Clean worker', '01120145637', '06:00:00', '15:00:00', 10),
(108, 'Ahmed', 'Khaled', 42, 3600, 'Bachelor', 'Receptionist', '01514785321', '15:00:00', '00:00:00', 9),
(109, 'Hisham', 'Zakaria', 50, 4200, 'High School', 'Clean worker', '01254796761', '06:00:00', '15:00:00', 10),
(110, 'Mohamed', 'Alaa', 51, 6500, 'Bachelor', 'Accountant', '01154782149', '15:00:00', '00:00:00', 8),
(111, 'Asmaa', 'Mohamed', 23, 1800, 'High School', 'Clean worker', '01247953175', '06:00:00', '15:00:00', 10),
(112, 'Rana', 'Sayed', 38, 8000, 'Bachelor', 'Accountant', '01084527961', '06:00:00', '15:00:00', 8),
(113, 'Fahd', 'Hossam', 55, 6000, 'Diploma', 'Receptionist', '01087462198', '15:00:00', '00:00:00', 9),
(114, 'Mina', 'Melad', 45, 1800, 'Bachelor', 'Accountant', '01579561442', '15:00:00', '00:00:00', 8),
(115, 'Mohamed', 'Adham', 48, 6400, 'Diploma', 'Accountant', '01114874224', '06:00:00', '15:00:00', 8),
(116, 'Nafady', 'Mahmoud', 35, 1850, 'High School', 'Clean worker', '01089894521', '15:00:00', '00:00:00', 10),
(117, 'Essam', 'Talaat', 39, 2100, 'Bachelor', 'Clean worker', '01121863274', '15:00:00', '00:00:00', 10),
(118, 'Tasneem', 'Mekky', 29, 5100, 'High School', 'Receptionist', '01147921366', '06:00:00', '15:00:00', 9),
(119, 'Fares', 'Ashraf', 26, 4300, 'Bachelor', 'Accountant', '01055489614', '15:00:00', '00:00:00', 8),
(120, 'Mayada', 'Abdullah', 31, 2400, 'Bachelor', 'Accountant', '01514862347', '06:00:00', '15:00:00', 8),
(121, 'Mohamed', 'Ihab', 28, 2400, 'High School', 'Receptionist', '01121578963', '15:00:00', '00:00:00', 9)

insert into Doctor
values
(1,  'Shawky', 'Ahmed', '01048724338', 25, 7500, 'Giza', 'Mohy', 5,'06:00:00', '12:00:00', 5, NULL),
(2,  'Farida', 'Kasem', '01557486314', 28, 8600, 'Cairo', 'Alteraa', 10, '12:00:00', '18:00:00', 6, NULL),
(3,  'Medhat', 'Emad', '01248362545', 25, 10500, 'Giza', 'Morad', 8, '12:00:00', '18:00:00', 5, NULL),
(4,  'Hossam', 'Ragab', '01086784652', 30, 11000, 'Cairo', 'Imbaba', 3, '12:00:00', '18:00:00', 3, '2018-6-12'),
(5,  'Magdy',	'Samir', '01221546855', 31, 9200, 'Cairo', 'Alshaheed', 18,  '06:00:00', '12:00:00', 3, NULL),
(6,  'Amr', 'Hany', '01023135487', 35, 13000, 'Giza', 'Algamaa', 35, '06:00:00', '12:00:00', 7, NULL),
(7,  'Karim', 'Moataz', '01521657685', 34, 12500, 'Cairo', 'Serag', 18, '06:00:00', '12:00:00', 1, NULL),
(8,  'Mahmoud', 'Ashraf', '01067865665', 40, 9800, 'Giza', 'Mekki', 10, '12:00:00', '18:00:00', 4, NULL),
(9,  'Hamada', 'Sherif', '01254544589', 45, 8000, 'Cairo', 'Ahmed Zaki', 30, '06:00:00', '12:00:00', 2, NULL),
(10, 'Saly', 'Adel', '01031232113', 52, 7800, 'Alexandrea', 'Alkournish', 20, '18:00:00', '00:00:00', 6, NULL),
(11, 'Fady', 'Mohamed', '01232654878', 48, 11000, 'Cairo', '105', 80, '12:00:00', '18:00:00', 7, NULL),
(12, 'Ezzat', 'ghareb', '01048451522', 43, 14000, 'Cairo', '9', 12, '18:00:00', '00:00:00', 4, NULL),
(13, 'Sereen', 'Saad', '01112135458', 33, 12000, 'Alexandrea', 'Almahkama', 15, '12:00:00', '18:00:00', 1, NULL),
(14, 'Attia', 'Samy', '01565465123', 27, 11500, 'Menoufia', 'Alzahraa', 13, '18:00:00', '00:00:00', 1, NULL),
(15, 'Mohamed', 'Ashour', '01533548786', 26, 10900, 'Sinai', 'Ahmed Nagiub', 41, '06:00:00', '12:00:00', 6, NULL),
(16, 'Shahenda', 'Walid', '01032131548', 44, 9800, 'Matrouh', 'Alexandria', 14, '12:00:00', '18:00:00', 2, NULL),
(17, 'Menna', 'Azaro', '01132132158', 38, 7600, 'Menoufia', 'Shehab', 1, '06:00:00', '12:00:00', 3, NULL),
(18, 'Ahmed', 'Soliman', '01065465456', 31, 8000, 'Aswan', 'Alnoba', 4, '12:00:00', '18:00:00', 5, '2017-2-24'),
(19, 'Seif', 'Abdullah', '01165662211', 55, 9300, 'Suez', 'Darwish', 6, '18:00:00', '00:00:00', 3, NULL),
(20, 'Nagy', 'Fathy', '01165487899', 60, 7800, 'Suez', 'Gad', 9, '18:00:00', '00:00:00', 2, NULL)

insert into Patient
values
(501,  'John', 'Cena', 'MedNet', 24, '01154875664', 'Giza', NULL),
(502,  'Ashraf', 'Allam', NULL, 12, '01054621568', 'Cairo', 'Shehab'),
(503,  'Hamada', 'Helal', NULL, 5,  '01554878452', 'Giza', 'Mohy'),
(504,  'Hoda', 'Elmasry', NULL, 1,  '01132115487', 'Cairo', 'Morad'),
(505,  'Gamal', 'Abdelnaser', 'Misr', 35, '01116516548', 'Cairo', NULL),
(506,  'Ahmed', 'Gamal', 'Health care', 68, '01056515486', 'Giza', 'Ahmed Nagiub'),
(507,  'Medhat', 'Elmeseery', 'Misr', 46, '01565165224', 'Cairo', NULL),
(508,  'Ebtsam', 'Mansour', NULL, 18, '01265489844', 'Giza', 'Ahmed Zaki'),
(509,  'Farah', 'Mohamed', 'MedNet', 58, '01165651222', 'Cairo', 'Serag'),
(510, 'Ahmed', 'Fathy', 'Health care', 29, '01556488861', 'Alexandrea', 'Mekki'),
(511, 'Ashrakat', 'Elsaeed', 'Misr', 14, '01022448667', 'Cairo', 'Alkournish'),
(512, 'Saad', 'Samir', NULL, 2,  '01565421325', 'Cairo', NULL),
(513, 'Israa', 'Abdelmaksoud', 'Health care', 22, '01154654887', 'Alexandrea', 'Alzahraa'),
(514, 'Karim', 'Hisham', 'Misr', 20, '01065468852', 'Menoufia', 'Algamaa'),
(515, 'Mohamed', 'Mamdouh', 'MedNet', 45, '01523566200', 'Sinai', 'Alteraa'),
(516, 'Nasser', 'Ali', 'Misr', 70, '01202404887', 'Matrouh', 'Darwish'),
(517, 'Mohamed', 'Ahmed', 'MedNet', 53, '01002354874', 'Menoufia', 'Gad'),
(518, 'Adham', 'Mohamed', 'Misr', 62, '01121400579', 'Aswan', NULL),
(519, 'Intsar', 'Zein', NULL, 49, '01200254876', 'Suez', NULL),
(520, 'Mohamed', 'Ragab', 'Health care', 55, '01056154880', 'Suez', 'Alexandria')


insert into Nurse
values
(401,  'Alaa', 'Sameh', '01014589632', 25, 6500, '06:00:00', '12:00:00', NULL),
(402,  'Fatma', 'Ahmed', '01154783214', 28, 6200, '12:00:00', '18:00:00', NULL),
(403,  'Rana', 'Foaad', '01552186321', 25, 7000, '12:00:00', '18:00:00', NULL),
(404,  'Sama', 'Mohamed', '01254896321', 30, 5800, '12:00:00', '18:00:00', '2018-06-12'),
(405,  'Nada', 'Farid', '01521489647', 31, 4900, '06:00:00', '12:00:00', NULL),
(406,  'Radwa', 'Sherif', '01054879632', 35, 6100, '06:00:00', '12:00:00', NULL),
(407,  'Farida', 'Moheb', '01120145637', 34, 5200, '06:00:00', '12:00:00', NULL),
(408,  'Nesreen', 'Khaled', '01514785321', 40, 4800, '12:00:00', '18:00:00', NULL),
(409,  'Reham', 'Zakaria', '01254796761', 45, 5500, '06:00:00', '12:00:00', NULL),
(410, 'Aliaa', 'Alaa', '01154782149', 34, 6000, '18:00:00', '00:00:00', NULL),
(411, 'Amira', 'Mohamed', '01247953175', 48, 4500, '12:00:00', '18:00:00', NULL),
(412, 'Zahraa', 'Sayed', '01084527961', 43, 4900, '18:00:00', '00:00:00', NULL),
(413, 'Sahar', 'Hossam', '01087462198', 33, 5900, '12:00:00', '18:00:00', NULL),
(414, 'Samar', 'Salem', '01579561442', 27, 7200, '18:00:00', '00:00:00', NULL),
(415, 'Gamila', 'Adham', '01114874224', 26, 4600, '06:00:00', '12:00:00', NULL),
(416, 'Salma', 'Mahmoud', '01089894521', 44, 6100, '12:00:00', '18:00:00', NULL),
(417, 'Amina', 'Talaat', '01121863274', 38, 4600, '06:00:00', '12:00:00', NULL),
(418, 'Amal', 'Mekky', '01147921366', 31, 5200, '12:00:00', '18:00:00', '2017-02-24'),
(419, 'Kariman', 'Ashraf', '01055489614', 34, 6800, '18:00:00', '00:00:00', NULL),
(420, 'Sara', 'Abdullah', '01514862347', 25, 6700, '18:00:00', '00:00:00', NULL)

insert into Clinic
values
(201, 1, 1),
(202, 1, 2),
(203, 1, 3),
(204, 1, 4),
(205, 1, 5),
(206, 2, 1),
(207, 2, 2),
(208, 2, 3),
(209, 2, 4),
(210, 2, 5),
(211, 3, 1),
(212, 3, 2),
(213, 3, 3),
(214, 3, 4),
(215, 3, 5),
(216, 3, 6),
(217, 4, 1),
(218, 4, 2),
(219, 4, 3),
(220, 4, 4),
(221, 4, 5),
(222, 4, 6),
(223, 5, 1),
(224, 5, 2),
(225, 5, 3),
(226, 5, 4),
(227, 5, 5),
(228, 6, 1),
(229, 6, 2),
(230, 6, 3),
(231, 6, 4),
(232, 6, 5),
(233, 6, 6),
(234, 7, 1),
(235, 7, 2),
(236, 7, 3),
(237, 7, 4),
(238, 7, 5),
(239, 7, 6),
(240, 7, 7)

insert into Doctor_Clinic
values
(1,  201, '06:00:00','09:00:00'),
(2,  202, '12:00:00','15:00:00'),
(3,  203, '15:00:00','18:00:00'),
(4,  204, '15:00:00','18:00:00'),
(5,  205, '09:00:00','12:00:00'),
(6,  206, '06:00:00','09:00:00'),
(7,  207, '06:00:00','09:00:00'),
(8,  208, '12:00:00','15:00:00'),
(9,  209, '06:00:00','09:00:00'),
(10, 210, '18:00:00','21:00:00'),
(11, 211, '15:00:00','18:00:00'),
(12, 212, '18:00:00','21:00:00'),
(13, 213, '12:00:00','15:00:00'),
(14, 214, '21:00:00','00:00:00'),
(15, 215, '09:00:00','12:00:00'),
(16, 216, '15:00:00','18:00:00'),
(17, 217, '06:00:00','09:00:00'),
(18, 218, '12:00:00','15:00:00'),
(19, 219, '21:00:00','00:00:00'),
(20, 220, '21:00:00','00:00:00')

insert into Nurse_Clinic
values
(401, 201, '06:00:00','09:00:00'),
(402, 202, '12:00:00','15:00:00'),
(403, 203, '15:00:00','18:00:00'),
(404, 204, '15:00:00','18:00:00'),
(405, 205, '09:00:00','12:00:00'),
(406, 206, '06:00:00','09:00:00'),
(407, 207, '06:00:00','09:00:00'),
(408, 208, '12:00:00','15:00:00'),
(409, 209, '06:00:00','09:00:00'),
(410, 210, '18:00:00','21:00:00'),
(411, 211, '15:00:00','18:00:00'),
(412, 212, '18:00:00','21:00:00'),
(413, 213, '12:00:00','15:00:00'),
(414, 214, '21:00:00','00:00:00'),
(415, 215, '09:00:00','12:00:00'),
(416, 216, '15:00:00','18:00:00'),
(417, 217, '06:00:00','09:00:00'),
(418, 218, '12:00:00','15:00:00'),
(419, 219, '21:00:00','00:00:00'),
(420, 220, '21:00:00','00:00:00')

insert into Appointment(AID, Dssn, Pssn, Date_Time)
values
(1001, 4, 501,  '2020-1-2 15:00:00'),
(1002, 1, 502,  '2020-1-2 06:00:00'),
(1003, 10, 503,  '2020-1-2 18:00:00'),
(1004, 12, 504,  '2020-1-3 18:00:00'),
(1005, 19, 505,  '2020-1-4 21:00:00'),
(1006, 14, 506,  '2020-1-5 21:00:00'),
(1007, 7, 507,  '2020-1-4 06:00:00'),
(1008, 20, 508,  '2020-1-6 21:00:00'),
(1009, 18, 509,  '2020-1-7 12:00:00'),
(1010, 14, 510, '2020-1-8 21:00:00'),
(1011, 5, 511, '2020-1-5 09:00:00'),
(1012, 13, 512, '2020-1-1 12:00:00'),
(1013, 5, 513, '2020-1-3 09:00:00'),
(1014, 8, 514, '2020-1-4 12:00:00'),
(1015, 12, 515, '2020-1-6 18:00:00'),
(1016, 3, 516, '2020-1-7 15:00:00'),
(1017, 16, 517, '2020-1-6 15:00:00'),
(1018, 9, 518, '2020-1-1 06:00:00'),
(1019, 2, 519, '2020-1-2 12:00:00'),
(1020, 10, 520, '2020-1-3 18:00:00')

insert into Dependencies
values
('Fady', 501,  24, '01154781214', 'Brother'),
('Heba', 502,  23, '01552183321', 'Sister'),
('Ahmed', 503,  42, '01254836321', 'Father'),
('Salama', 504,  50, '01521589647', 'Father'),
('Hoda', 505,  51, '01054876632', 'Mother'),
('Mohsen', 506,  23, '01120045637', 'Son'),
('Gamal', 507,  38, '01514705321', 'Brother'),
('Yara', 508,  10, '01254790761', 'Daughter'),
('Abdelrahman', 509,  62, '01104782149', 'Father'),
('Abdullah', 510, 18, '01247903175', 'Son'),
('Nameer', 511, 35, '01084527061', 'Sister'),
('Soliman', 512, 65, '01087460198', 'Father'),
('Nermeen', 513, 55, '01579560442', 'Mother'),
('Seif', 514, 26, '01114874220', 'Brother'),
('Ibtsam', 515, 31, '01089894021', 'Sister')

insert into Room(RID, Floor, numInFloor)
values
(301, 1, 1),
(302, 1, 2),
(303, 1, 3),
(304, 1, 4),
(305, 1, 5),
(306, 2, 1),
(307, 2, 2),
(308, 2, 3),
(309, 2, 4),
(310, 2, 5),
(311, 3, 1),
(312, 3, 2),
(313, 3, 3),
(314, 3, 4),
(315, 3, 5),
(316, 3, 6),
(317, 4, 1),
(318, 4, 2),
(319, 4, 3),
(320, 4, 4),
(321, 4, 5),
(322, 4, 6),
(323, 5, 1),
(324, 5, 2),
(325, 5, 3),
(326, 5, 4),
(327, 5, 5),
(328, 6, 1),
(329, 6, 2),
(330, 6, 3),
(331, 6, 4),
(332, 6, 5),
(333, 6, 6),
(334, 7, 1),
(335, 7, 2),
(336, 7, 3),
(337, 7, 4),
(338, 7, 5),
(339, 7, 6),
(340, 7, 7)

insert into Doc_Room
values
(1,  301),
(2,  302),
(3,  303),
(4,  304),
(5,  305),
(6,  306),
(7,  307),
(8,  308),
(9,  309),
(10, 310),
(11, 311),
(12, 312),
(13, 313),
(14, 314),
(15, 315),
(16, 316),
(17, 317),
(18, 318),
(19, 319),
(20, 320),
(1,  321),
(2,  322),
(3,  323),
(4,  324),
(5,  325),
(6,  326),
(7,  327),
(8,  328),
(9,  329),
(10, 330),
(11, 331),
(12, 332),
(13, 333),
(14, 334),
(15, 335),
(16, 336),
(17, 337),
(18, 338),
(19, 339),
(20, 340)

insert into Nurse_Room
values
(401, 301),
(402, 302),
(403, 303),
(404, 304),
(405, 305),
(406, 306),
(407, 307),
(408, 308),
(409, 309),
(410, 310),
(411, 311),
(412, 312),
(413, 313),
(414, 314),
(415, 315),
(416, 316),
(417, 317),
(418, 318),
(419, 319),
(420, 320),
(401, 321),
(402, 322),
(403, 323),
(404, 324),
(405, 325),
(406, 326),
(407, 327),
(408, 328),
(409, 329),
(410, 330),
(411, 331),
(412, 332),
(413, 333),
(414, 334),
(415, 335),
(416, 336),
(417, 337),
(418, 338),
(419, 339),
(420, 340)

insert into Drugs
values
(5001, 'Amoxicilin', 50, 11.25),
(5002, 'Vicodin', 35, 9.5),
(5003, 'Asprine', 40, 0.5),
(5004, 'Vitamin', 80, 5.0),
(5005, 'Ezafluor', 60, 13.75),
(5006, 'Revo', 19, 20.25),
(5007, 'Panadol', 26, 15.5),
(5008, 'Panadol extra', 95, 7.5),
(5009, 'Cephalexin', 57, 11.5),
(5010, 'Roxithromycin', 63, 8.0),
(5011, 'Tabramycin', 64, 4.0),
(5012, 'Tinidazole', 70, 2.0),
(5013, 'Nitrofurantoin', 44, 3.5),
(5014, 'Minocycline', 30, 2.75),
(5015, 'Dapsone', 18, 14.5),
(5016, 'Fusidic acid', 48, 16.5),
(5017, 'Ofloxacin', 43, 14.0),
(5018, 'Cefalotin', 39, 18.5),
(5019, 'Antocid', 29, 20.5),
(5020, 'depovit', 25, 32.5)
