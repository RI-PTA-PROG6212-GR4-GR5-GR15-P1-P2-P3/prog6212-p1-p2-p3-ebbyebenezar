CREATE TABLE Result
(
    ResultID INT IDENTITY(1,1) PRIMARY KEY,
    RegistrationID INT NOT NULL UNIQUE,
    FinishTime TIME NOT NULL,
    Position INT NOT NULL,
    ResultStatus VARCHAR(20) NOT NULL DEFAULT 'Finished',

    CONSTRAINT FK_Result_Registration
        FOREIGN KEY (RegistrationID)
        REFERENCES Registration(RegistrationID)
);