CREATE TABLE EventTypes (
    EventTypeId INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100) NOT NULL
);

INSERT INTO EventTypes (Name) VALUES ('Wedding'), ('Conference'), ('Birthday');

CREATE TABLE Venues (
    VenueId INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100) NOT NULL,
    IsAvailable BIT NOT NULL,
    DateAvailable DATE NOT NULL,
    EventTypeId INT FOREIGN KEY REFERENCES EventTypes(EventTypeId)
);

INSERT INTO Venues (Name, IsAvailable, DateAvailable, EventTypeId) VALUES
('Varsity College', 1, '2025-06-15', 1),
('My House', 0, '2025-06-20', 2),
('Westville', 1, '2025-06-25', 3);