CREATE TABLE Weather
(
    WeatherID INT IDENTITY(1,1) PRIMARY KEY,
    EventID INT NOT NULL,
    WeatherDate DATE NOT NULL,
    Temperature DECIMAL(5,2) NOT NULL,
    WeatherCondition VARCHAR(50) NOT NULL,
    WindSpeed DECIMAL(5,2) NOT NULL DEFAULT 0,

    CONSTRAINT FK_Weather_Event
        FOREIGN KEY (EventID)
        REFERENCES Event(EventID),

    CONSTRAINT UQ_Weather_Event_Date
        UNIQUE (EventID, WeatherDate)
);