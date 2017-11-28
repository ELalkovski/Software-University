SELECT COUNT(*) AS [CountryCode] FROM
(SELECT c.CountryCode,
       m.Id FROM Countries AS c
LEFT JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
LEFT JOIN Mountains AS m ON mc.MountainId = m.Id
WHERE m.Id IS NULL) AS x