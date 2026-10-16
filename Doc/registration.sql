CREATE TABLE Registration
(
    RegistrationID INT IDENTITY(1,1) PRIMARY KEY,
    ParticipantID INT NOT NULL,
    EventID INT NOT NULL,
    CategoryID INT NOT NULL,
    RegistrationDate DATE NOT NULL DEFAULT GETDATE(),
    RegistrationStatus VARCHAR(20) NOT NULL DEFAULT 'Confirmed',

    CONSTRAINT FK_Registration_Participant
        FOREIGN KEY (ParticipantID)
        REFERENCES Participant(ParticipantID),

    CONSTRAINT FK_Registration_Event
        FOREIGN KEY (EventID)
        REFERENCES Event(EventID),

    CONSTRAINT FK_Registration_Category
        FOREIGN KEY (CategoryID)
        REFERENCES Category(CategoryID),

    CONSTRAINT UQ_Registration_Participant_Event
        UNIQUE (ParticipantID, EventID)
);