CREATE TABLE Route
(
    RouteID INT IDENTITY(1,1) PRIMARY KEY,
    EventID INT NOT NULL,
    RouteName VARCHAR(100) NOT NULL,
    Distance DECIMAL(6,2) NOT NULL,
    RouteDescription VARCHAR(500) NOT NULL,

    CONSTRAINT FK_Route_Event
        FOREIGN KEY (EventID)
        REFERENCES Event(EventID),

    CONSTRAINT UQ_Route_Event
        UNIQUE (EventID, RouteName)
);