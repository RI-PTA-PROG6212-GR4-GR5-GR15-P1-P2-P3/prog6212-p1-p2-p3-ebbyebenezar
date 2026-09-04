CREATE TABLE Event
(
    EventID INT IDENTITY(1,1) PRIMARY KEY,
    OrganiserID INT NOT NULL,
    EventName VARCHAR(100) NOT NULL,
    EventDate DATE NOT NULL,
    Location VARCHAR(100) NOT NULL,
    EventType VARCHAR(30) NOT NULL DEFAULT 'Running',

    CONSTRAINT FK_Event_Organiser
        FOREIGN KEY (OrganiserID)
        REFERENCES Organiser(OrganiserID)
);