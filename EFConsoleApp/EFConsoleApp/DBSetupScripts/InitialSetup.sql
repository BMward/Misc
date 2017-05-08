use Inventory
GO

CREATE TABLE Items
(
	InventoryId int IDENTITY(1,1) not null,
	ItemDescription nvarchar(300),
	InStock int,
	AcquisitionCost float,
	ListPrice float
)

CREATE TABLE Customers
(
	CustomerId int IDENTITY(1,1) not null,
	FirstName nvarchar(100),
	LastName nvarchar(100),
	PhoneNumber nvarchar(15),
	Email nvarchar(100)
)

CREATE TABLE TransactionHinge
(
	TransactionId int IDENTITY(1,1) not null,
	CustomerId int,
	InventoryId int
)