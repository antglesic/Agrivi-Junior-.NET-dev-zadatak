CREATE TABLE [dbo].[Spojevi] (
    [idSpoja]    INT          NOT NULL,
    [nazivSpoja] VARCHAR (50) NOT NULL,
    [vodik]      INT          NOT NULL,
    [ugljik]     INT          NOT NULL,
    [dusik]      INT          NOT NULL,
    [natrij]     INT          NOT NULL,
    [kisik]      INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([idSpoja] ASC)
);

