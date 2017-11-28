ALTER TABLE Users
ADD CONSTRAINT CK_PassAtLeastFiveSymbols
CHECK (LEN([Password]) >= 5)