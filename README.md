# MudBlazorCrudST
Code Blazor
Instruction

Execute script in Sql Server database: 

Create Table Animals (

    AnimalId int IDENTITY(1,1) PRIMARY KEY,
    
    Name varchar(255) NOT NULL,
    
    Breed varchar(255),
    
    BirthDate datetime,
    
    Sex varchar(6),
    
    Price decimal(16,2),
    
    Status varchar(8),
    
    Selected bit
);


Execute data:

Insert Into Animals (Name, Breed, BirthDate, Sex, Price, Status, Selected)
Values('Bella', 'Pardo', '20230601', 'Female', 1000000, 'Active', 0)

Insert Into Animals (Name, Breed, BirthDate, Sex, Price, Status, Selected)
Values('Charlie', 'Aberdeen Angus', '20230601', 'Male', 600, 'Inactive', 0)

Insert Into Animals (Name, Breed, BirthDate, Sex, Price, Status, Selected)
Values('Sam', 'Limousin', '20230602', 'Female', 850, 'Active', 0)

Insert Into Animals (Name, Breed, BirthDate, Sex, Price, Status, Selected)
Values('Luna', 'Pardo', '20230602', 'Male', 350, 'Inactive', 0)

Insert Into Animals (Name, Breed, BirthDate, Sex, Price, Status, Selected)
Values('Sol', 'Aberdeen Angus', '20230603', 'Female', 1500000, 'Active', 0)

Insert Into Animals (Name, Breed, BirthDate, Sex, Price, Status, Selected)
Values('Klifor', 'Limousin', '20230603', 'Male', 15000, 'Inactive', 0)

Insert Into Animals (Name, Breed, BirthDate, Sex, Price, Status, Selected)
Values('Nala', 'Pardo', '20230604', 'Female', 35000, 'Active', 0)

Insert Into Animals (Name, Breed, BirthDate, Sex, Price, Status, Selected)
Values('Andina', 'Aberdeen Angus', '20230604', 'Male', 86000, 'Inactive', 0)

Insert Into Animals (Name, Breed, BirthDate, Sex, Price, Status, Selected)
Values('Marte', 'Limousin', '20230605', 'Female', 300, 'Active', 0)

Insert Into Animals (Name, Breed, BirthDate, Sex, Price, Status, Selected)
Values('Grood', 'Pardo', '20230605', 'Male', 800, 'Inactive', 0)

Insert Into Animals (Name, Breed, BirthDate, Sex, Price, Status, Selected)
Values('Neblina', 'Aberdeen Angus', '20230606', 'Female', 100, 'Active', 0)

Insert Into Animals (Name, Breed, BirthDate, Sex, Price, Status, Selected)
Values('Mate', 'Limousin', '20230606', 'Male', 5500, 'Inactive', 0)

Insert Into Animals (Name, Breed, BirthDate, Sex, Price, Status, Selected)
Values('Corde', 'Pardo', '20230607', 'Female', 350, 'Active', 0)

Insert Into Animals (Name, Breed, BirthDate, Sex, Price, Status, Selected)
Values('Samu', 'Aberdeen Angus', '20230607', 'Male', 6000, 'Inactive', 0)


Consult information:

Select * From Animals


Others:

--Drop Table Animals
--Delete From Animals

Open the solution MudBlazorCrudST 
 
Find and open the file appsettings.json
 
Change the connection string in the file appsettings.json: Server / Database / User Id / Password
 

