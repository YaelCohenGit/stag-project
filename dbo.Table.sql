CREATE TABLE [dbo].[WantedApt]
(
	[WantedAptId] INT NOT NULL , 
	[touristId] INT NOT NULL , 
    [WantedBeds] INT NULL, 
    [WantedCountry] NCHAR(10) NULL, 
    [WantedMinPrice] INT NULL, 
    [WantedMaxPrice] INT NULL,
	FOREIGN KEY (touristId) REFERENCES Tourists(TouristId), 
    CONSTRAINT [PK_WantedApt] PRIMARY KEY ([WantedAptId])
)
