USE Geography

SELECT CountryName, IsoCode FROM Countries
WHERE LEN(CountryName) - LEN(REPLACE(CountryName, 'A','' )) > 2
ORDER BY IsoCode