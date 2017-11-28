SELECT SUM(XX.Diff) AS [SumDifference]
FROM (SELECT DepositAmount - (SELECT DepositAmount FROM WizzardDeposits WHERE Id = f.Id + 1)
	    AS Diff FROM WizzardDeposits f) AS XX 